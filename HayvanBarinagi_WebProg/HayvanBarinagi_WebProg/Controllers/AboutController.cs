using Microsoft.AspNetCore.Mvc;
using HayvanBarinagi_WebProg.Models.Siniflar;

namespace TraverTripProject.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}
