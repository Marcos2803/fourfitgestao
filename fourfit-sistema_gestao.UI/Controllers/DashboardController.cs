using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class DashboardController : Controller
    {
       [Authorize]
        public IActionResult BemVindo()
        {
            ///fsdfsdfsfsf
            ///
            /*
             sdfsdfsfdsdffsd
             
             sf*/
            return View();
        }
    }
}
