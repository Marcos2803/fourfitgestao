using fourfit_sistema_gestao.UI.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (model.UserName != null && model.Password != null)
            {

            }
            else
            {
                ViewBag.MsgError = "Usuario ou senha não foram informados";
            }
            return View(model);
        }
        [HttpGet]
        public async  Task<IActionResult> Cadastro()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cadastro(CadastroViewModel cadastroViewModel)
        {

            return View();
        }


    }
}
