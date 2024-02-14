using fourfit_sistema_gestao.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
