﻿using Microsoft.AspNetCore.Mvc;
using HayvanBarinagi_WebProg.Models.Siniflar;

namespace TraverTripProject.Controllers
{
    public class BlogController : Controller
    {
        //Context c = new Context();
        //BlogYorum by = new BlogYorum();

        public IActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            //by.Deger1 = c.Blogs.ToList();
            //by.Deger3 = c.Blogs.Take(3).ToList();
            //by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View();
        }


        public IActionResult BlogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            //by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            //by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View();
        }
    }
}