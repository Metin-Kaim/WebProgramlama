using Microsoft.AspNetCore.Mvc;
using Barinak.Models.Siniflar;
namespace Barinak.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler=c.Blogs.OrderByDescending(x=>x.ID).Take(6).ToList();//for slider
            return View(degerler);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
