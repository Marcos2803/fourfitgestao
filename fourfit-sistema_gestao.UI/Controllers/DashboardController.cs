using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fourfit_sistema_gestao.UI.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
      
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
