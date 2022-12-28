using Microsoft.AspNetCore.Mvc;
using HayvanBarinagi_.Models.Siniflar;

namespace HayvanBarinagi_.Controllers
{
    public class BakimRehberiController : Controller
    {
        Context c = new Context();
        BakimRehberiYorum by = new BakimRehberiYorum();
        public IActionResult Index()
        {
            //var bilgiler = c.BakimRehberis.ToList();
            by.Deger1 = c.BakimRehberis.ToList();
            by.Deger3 = c.BakimRehberis.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(by);
        }
        
        public IActionResult BilgiDetay(int id)
        {
            //var bilgibul = c.BakimRehberis.Where(x => x.Id == id).ToList();
            by.Deger1=c.BakimRehberis.Where(x=>x.Id==id).ToList();
            by.Deger2=c.Yorumlars.Where(x=>x.RehberId==id).ToList();
            return View(by);
        }
    }
}
