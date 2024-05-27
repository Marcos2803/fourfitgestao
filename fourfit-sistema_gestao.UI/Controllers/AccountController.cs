using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit_sistema_gestao.UI.Models.Account;
using fourfit_sistema_gestao.UI.Models;
using fourfit_sistema_gestao.UI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using NuGet.Common;





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
                                    ModelState.AddModelError(string.Empty, "Conta em processo de autorização");
                                    return View();
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
            //var usuario = new CadastroViewModel
            //{
                //NomeCompleto = "Roberto Carlos da Silva",
                //Email = "roberto@gmail.com",
                //Password = "*SenhaPadrao123*",
                //PasswordConfirmn = "*SenhaPadrao123*",
                //Cpf = "334.288.110-03",
                //Celular = "19988696402",
                //Cep = "89160-242",
                //Endereco = "Travessa Radialista Nilton Novais",
                //Numero = 100,
                //Bairro = "Jardim America",
                //Cidade = "Campinas",
                //Estado = "SP",
                //DataNacimento = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), //Convert.ToDateTime("10/10/1980"),
                //Genero = "M"

            //};
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
                    var CpfRemoverMascara = cadastroViewModel.Cpf.ToString().Replace(".", "").Replace("-", "");
                    user = new User
                    {
                        Id = Guid.NewGuid().ToString(),
                        NomeCompleto = cadastroViewModel.NomeCompleto,
                        Email = cadastroViewModel.Email,
                        UserName = cadastroViewModel.Email,
                        PasswordHash = cadastroViewModel.Password,
                        Cpf = Convert.ToInt64(CpfRemoverMascara),
                        Celular = cadastroViewModel.Celular,
                        Cep = cadastroViewModel.Cep,
                        Endereco = cadastroViewModel.Cep,
                        Numero = cadastroViewModel.Numero,
                        Bairro = cadastroViewModel.Bairro,
                        Cidade = cadastroViewModel.Cidade,
                        Estado = cadastroViewModel.Estado,
                        DataNacimento = cadastroViewModel.DataNacimento,
                        Genero = cadastroViewModel.Genero,
                    };



                    var resultado = await _userManager.CreateAsync(user, cadastroViewModel.Password);
                    var confirmarEmail = string.Empty;
                    if (resultado.Succeeded)
                    {
                        confirmarEmail = cadastroViewModel.Email;
                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        System.IO.File.WriteAllText("confirmeEmail.text", confirmarEmail);
                        TempData["msg"] = $"Usuario {cadastroViewModel.NomeCompleto}, cadastro com sucesso!";
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

    }
}
