using Microsoft.AspNetCore.Mvc;

namespace HayvanBarinagi_.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
