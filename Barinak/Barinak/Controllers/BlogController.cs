﻿using Barinak.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace Barinak.Controllers
{
	public class BlogController : Controller
	{
		Context c = new Context();
        BlogYorum by = new BlogYorum();

        public IActionResult Index()
		{
			//var degerler=c.Blogs.ToList();
			by.Deger1=c.Blogs.ToList();
			by.Deger3=c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
			return View(by);
		}
        public IActionResult BlogDetay(int id)
		{
			ViewBag.ID = id;
			by.Deger1=c.Blogs.Where(x=>x.ID==id).ToList();
			by.Deger2=c.Yorumlars.Where(x=>x.Blogid==id).ToList();
			//var blogBul=c.Blogs.Where(x=>x.ID==id).ToList();
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
			return RedirectToAction("BlogDetay");
		}


	}
}
