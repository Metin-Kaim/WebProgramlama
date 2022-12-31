using Microsoft.AspNetCore.Mvc;
using Barinak.Models.Siniflar;
namespace Barinak.Controllers
{
	public class AboutController : Controller
	{
		Context c=new Context();
		public IActionResult Index()
		{
			var degerler = c.Hakkimizdas.ToList();
			return View(degerler);
		}
	}
}
