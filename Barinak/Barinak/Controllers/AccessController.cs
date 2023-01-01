using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Barinak.Models.Siniflar;
using Microsoft.AspNetCore.Authentication;

namespace Barinak.Controllers
{
    public class AccessController : Controller
    {
        Context c=new Context();

        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if(claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Default");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(VMLogin modelLogin)
        {
            if(modelLogin.Email == "g201210072@sakarya.edu.tr" && 
                modelLogin.Password=="sau") 
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,modelLogin.Email),
                    new Claim("OtherProperties","Example Role")
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh= true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };


                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Admin");

            }


            ViewData["ValidateMessage"] = "user not found";

            return View();
        }
    }
}
