using Microsoft.AspNetCore.Mvc;
using HayvanBarinagi_.Models.Siniflar;

namespace HayvanBarinagi_.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var degerler = c.BakimRehberis.ToList();
            return View(degerler);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
