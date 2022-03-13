using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class LoginController : Controller
    {
        Context X = new Context();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Cari CS)
        {
            X.Caris.Add(CS);
            X.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult CariLogin1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CariLogin1(Cari cs)
        {

            var bilgiler = X.Caris.Where(x => x.CariMail == cs.CariMail && x.CariSifre == cs.CariSifre).SingleOrDefault();
            if (bilgiler != null)
            {
                HttpContext.Session.SetString("Mail", cs.CariMail);
               

                return RedirectToAction("Index","CariPanel");
                
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
