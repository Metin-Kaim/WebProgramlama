using Barinak.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;
namespace Barinak.Controllers
{
    public class GirisYap : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
		public IActionResult Login(Admin ad)
		{
            var bilgiler=c.Admins.FirstOrDefault
                (x=>x.Kullanici==ad.Kullanici&&x.Sifre==ad.Sifre);
            if(bilgiler!=null)
            {
                
            }
			return View();
		}
	}
}
