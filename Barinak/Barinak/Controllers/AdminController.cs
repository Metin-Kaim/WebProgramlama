using Microsoft.AspNetCore.Mvc;
using Barinak.Models.Siniflar;
using Microsoft.EntityFrameworkCore;

namespace Barinak.Controllers
{
    public class AdminController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            var degerler=c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniBlog()
        {
            return View();
        }
        public IActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BlogSil(int id)
        {
            var b=c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BlogGetir(int id)
        {
            var b=c.Blogs.Find(id);
            return View(b);
        }

        public IActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama=b.Aciklama;
            blg.Baslik=b.Baslik;
            blg.BlogImage=b.BlogImage;
            blg.Tarih=b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.Include(x => x.Blog).ToList();
            return View(yorumlar);
        }

        public IActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public IActionResult YorumGetir(int id)
        {
            var b = c.Yorumlars.Find(id);
            return View(b);
        }
        public IActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

    }
}
