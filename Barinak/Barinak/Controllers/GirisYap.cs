using Microsoft.AspNetCore.Mvc;

namespace Barinak.Controllers
{
    public class GirisYap : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
