using Barinak.Models.Siniflar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Barinak.Controllers
{
    [Authorize]
    public class RehberController : Controller
	{
		Context c = new Context();
        RehberYorum by = new RehberYorum();

        public IActionResult Index()
		{
			//var degerler=c.Rehbers.ToList();
			by.Deger1=c.Rehbers.ToList();
			by.Deger3=c.Rehbers.OrderByDescending(x=>x.ID).Take(5).ToList();
			return View(by);
		}
        public IActionResult RehberDetay(int id)
		{
			ViewBag.ID = id;
			by.Deger1=c.Rehbers.Where(x=>x.ID==id).ToList();
			by.Deger2=c.Yorumlars.Where(x=>x.Rehberid==id).ToList();
            by.Deger3 = c.Rehbers.OrderByDescending(x => x.ID).Take(5).ToList();
            //var RehberBul=c.Rehbers.Where(x=>x.ID==id).ToList();
            return View(by);
		}

		[HttpGet]
		public IActionResult YorumYap()
		{
			//TempData["ID"] = id;
			return PartialView();
		}

		[HttpPost]
		public IActionResult YorumYap(Yorumlar y)
		{
			c.Yorumlars.Add(y);
			c.SaveChanges();
			return RedirectToAction("RehberDetay");
		}

		

	}
}
