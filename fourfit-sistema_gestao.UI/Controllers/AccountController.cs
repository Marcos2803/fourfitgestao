using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit_sistema_gestao.UI.Models.Account;
using fourfit_sistema_gestao.UI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;





namespace fourfit_sistema_gestao.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IUserClaimsPrincipalFactory<User> _userClaimsPrincipalFactory;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager,
            IUserClaimsPrincipalFactory<User> userClaimsPrincipalFactory,
            UserManager<User> userManager
            )
        {
            _signInManager = signInManager;
            _userClaimsPrincipalFactory = userClaimsPrincipalFactory;
            _userManager = userManager;
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
           
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.UserName != null && model.Password != null)
                    {
                        var user = await _userManager.FindByNameAsync(model.UserName);
                        if (user != null && !await _userManager.IsLockedOutAsync(user))
                        {
                            if (await _userManager.CheckPasswordAsync(user, model.Password))
                            {
                                if (!await _userManager.IsEmailConfirmedAsync(user))
                                { 
                                    return BadRequest("Conta em processo de autorização.");
                                }

                                //DEU TUDO CERTO
                                await _userManager.ResetAccessFailedCountAsync(user);
                                var principal = await _userClaimsPrincipalFactory.CreateAsync(user);
                                await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, new System.Security.Claims.ClaimsPrincipal(principal));
                                return RedirectToAction("BemVindo", "Dashboard");

                            }
                            else
                            {
                                ModelState.AddModelError(string.Empty, "Senha incorreta.");
                                return View();
                            }
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Usuario bloqueado");
                        }
                    }
                    else
                    {
                        ViewBag.MsgError = "Usuario ou senha não foram informados";
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Houve um erro!");
                    return View();
                }


            }
            catch (Exception ex)
            {

                ModelState.AddModelError(string.Empty, ex.Message);
            }



            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Cadastro()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cadastro(CadastroViewModel cadastroViewModel)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(cadastroViewModel.Email);
                if (user == null)
                {
                    
                    user = new User
                    {
                        Id = Guid.NewGuid().ToString(),
                        PrimeiroNome = cadastroViewModel.PrimeiroNome,
                        SobreNome = cadastroViewModel.SobreNome,
                        Email = cadastroViewModel.Email,
                        UserName = cadastroViewModel.Email,
                        PasswordHash = cadastroViewModel.Password,
                       
                    };



                    var resultado = await _userManager.CreateAsync(user, cadastroViewModel.Password);
                    var confirmarEmail = string.Empty;
                    if (resultado.Succeeded)
                    {
                        confirmarEmail = cadastroViewModel.Email;
                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        System.IO.File.WriteAllText("confirmeEmail.text", confirmarEmail);
                        TempData["msg"] = $"Usuário {cadastroViewModel.PrimeiroNome}, cadastro com sucesso!";
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        foreach (var erro in resultado.Errors)
                        {
                            ModelState.AddModelError(string.Empty, erro.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Usuário já existe!");
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View();
        }
        //
        public IActionResult ForgotPassword()
        {
            return View();
        }
       
      
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel mod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.FindByEmailAsync(mod.Email);
                    if (user != null)
                    {

                        var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                        
                        var resetUrl = Url.Action("ResetPassword", "Account", new { token = token, email = mod.Email }, Request.Scheme);

                        System.IO.File.WriteAllText("resetLinkToNewPass", resetUrl);
                        var mail = new EmailServices();

                        var msg = new EmailAddressViewModel()
                        {
                            Subject = "E-mail enviado para alteração de senha",
                            To = mod.Email,
                            Body = resetUrl
                        };

                        await mail.SendEmailAsync(msg);
                        TempData["MsgEmailSucesso"] = "Email enviado com sucesso.";
                        TempData["ResetSenha"] = resetUrl;
                        return RedirectToAction(nameof(ConfirmPasswordSuccess));
                    }

                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", $"Ops, ocorreu um erro:  {ex.Message}");
            }
            return View();
        }

        public IActionResult ResetPassword(string token, string email)
        {
            
            return View(new ResetPasswordViewModel { Token = token, Email = email});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  async Task<IActionResult> ResetPassword(ResetPasswordViewModel mod)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var user = await _userManager.FindByEmailAsync(mod.Email);

                          if (user != null)
                    {
                        
                        var result = await _userManager.ResetPasswordAsync(user, mod.Token, mod.Password);
                        if (!result.Succeeded)
                        {
                            foreach (var erro in result.Errors)
                            {
                                ModelState.AddModelError("", erro.Description);
                            }

                            return View();
                        }

                        return View("Success");
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login", "Account");
            
        }
        public IActionResult ConfirmPasswordSuccess()
        {
            return View();
        }
        public IActionResult BemVindo()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
