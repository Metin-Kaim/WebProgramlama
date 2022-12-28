using Microsoft.AspNetCore.Mvc;
using HayvanBarinagi_.Models.Siniflar;

namespace HayvanBarinagi_.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var degerler=c.Hakkimizdas.ToList();

            return View(degerler);
        }
    }
}
