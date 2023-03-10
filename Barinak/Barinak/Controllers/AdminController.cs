using Microsoft.AspNetCore.Mvc;
using Barinak.Models.Siniflar;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Barinak.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            var degerler=c.Rehbers.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniRehber()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniRehber(Rehber p)
        {
            c.Rehbers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult RehberSil(int id)
        {
            var b=c.Rehbers.Find(id);
            c.Rehbers.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult RehberGetir(int id)
        {
            var b=c.Rehbers.Find(id);
            return View(b);
        }

        public IActionResult RehberGuncelle(Rehber b)
        {
            var blg = c.Rehbers.Find(b.ID);
            blg.Aciklama=b.Aciklama;
            blg.Baslik=b.Baslik;
            blg.RehberImage=b.RehberImage;
            blg.Tarih=b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.Include(x => x.Rehber).ToList();
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

        public IActionResult HayvanListesi()
        {
            var hayvanlar = c.Hayvanlars.Include(x=>x.Turler).ToList();
            return View(hayvanlar);
        }

        [HttpGet]
        public IActionResult YeniHayvan()
        {
            List<SelectListItem> degerler = (from x in c.Turlers.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.TurAd,
                                                 Value = x.ID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult YeniHayvan(Hayvanlar h)
        {
            var hay = c.Turlers.Where(x => x.ID == h.Turler.ID).FirstOrDefault();
            h.Turler = hay;
            c.Hayvanlars.Add(h);
            c.SaveChanges();
            return RedirectToAction("HayvanListesi");
        }

        public IActionResult HayvanSil(int id)
        {
            var b = c.Hayvanlars.Find(id);
            c.Hayvanlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("HayvanListesi");
        }

        public IActionResult HayvanGetir(int id)
        {
            var b = c.Hayvanlars.Find(id);
            return View(b);
        }

        public IActionResult HayvanGuncelle(Hayvanlar h)
        {
            var yrm = c.Hayvanlars.Find(h.ID);
            yrm.Adi = h.Adi;
            yrm.Yas = h.Yas;
            yrm.Cinsiyet = h.Cinsiyet;
            //yrm.Turid = h.Turid;
            yrm.FotoUrl = h.FotoUrl;
            yrm.Aciklama = h.Aciklama;
            c.SaveChanges();
            return RedirectToAction("HayvanListesi");
        }



        public IActionResult TurListesi()
        {
            var turler = c.Turlers.ToList();
            return View(turler);
        }

        [HttpGet]
        public IActionResult YeniTur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniTur(Turler t)
        {
            c.Turlers.Add(t);
            c.SaveChanges();
            return RedirectToAction("TurListesi");
        }

        public IActionResult TurSil(int id)
        {
            var b = c.Turlers.Find(id);
            c.Turlers.Remove(b);
            c.SaveChanges();
            return RedirectToAction("TurListesi");
        }

        public IActionResult TurGetir(int id)
        {
            var b = c.Turlers.Find(id);
            return View(b);
        }

        public IActionResult TurGuncelle(Turler tur)
        {
            var t = c.Turlers.Find(tur.ID);
            t.TurAd = tur.TurAd;
            c.SaveChanges();
            return RedirectToAction("TurListesi");
        }
    }
}
