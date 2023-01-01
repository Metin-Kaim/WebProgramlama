using Barinak.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace Barinak.Controllers
{
	public class HayvanController : Controller
	{
		Context c=new Context();

		public IActionResult Index()
		{
			var hayvanlar=c.Hayvanlars.ToList();//tüm hayvanları al
			return View(hayvanlar);
		}

        public IActionResult HayvanDetay(int id)
        {
			var deger = c.Hayvanlars.Find(id);
            return View(deger);
        }

        public IActionResult SeciliHayvan(int id)
		{
            var hayvanlar = c.Hayvanlars.Where(x=>x.Turid==id).ToList();
            return View(hayvanlar);
		}

        public IActionResult HayvanSahiplen(int id)
        {
            var b = c.Hayvanlars.Find(id);
            c.Hayvanlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
