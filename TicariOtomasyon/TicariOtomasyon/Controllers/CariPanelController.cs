using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class CariPanelController : Controller
    {

        Context x = new Context();

        
        public IActionResult Index(Cari cs)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Mail")))
            {
                return RedirectToAction("CariLogin1", "Login");
            }
            var sessionveri = HttpContext.Session.GetString("Mail");
            
    

            var degerler = x.Caris.FirstOrDefault(y => y.CariMail == sessionveri );
            ViewBag.dg = sessionveri;
            
                return View(degerler);
            
           
        }
        public IActionResult Sıparıslerım()
        {
            var sessionveri = HttpContext.Session.GetString("Mail");
            var id = x.Caris.Where(x=>x.CariMail==sessionveri).Select(y=>y.CariId).FirstOrDefault();
            var degerler = x.SatısHarekets.Where(x => x.CariId == id).Include(t => t.Ürünler).ToList();
            return View(degerler);
        }
        public IActionResult LogOff()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");

        }
        public ActionResult GelenMesajlar()
        {
            var sessionveri = HttpContext.Session.GetString("Mail");

            var mesajlar = x.Mesajlars.Where(x => x.Alıcı == sessionveri).ToList();
            var gelensayısı = x.Mesajlars.Count(x => x.Alıcı == sessionveri).ToString();
            ViewBag.d1 = gelensayısı;
            return View(mesajlar);
        }
        public ActionResult GidenMesajlar()
        {
            var sessionveri = HttpContext.Session.GetString("Mail");

            var mesajlar = x.Mesajlars.Where(x => x.Gonderici == sessionveri).ToList();
            var gelensayısı = x.Mesajlars.Count(x => x.Gonderici == sessionveri).ToString();
            ViewBag.d2 = gelensayısı;
            return View(mesajlar);
        }
        public ActionResult MesajDetay(int id)
        {
            var degerler = x.Mesajlars.Where(x => x.MesajId == id).ToList();
                var sessionveri = HttpContext.Session.GetString("Mail");

                var mesajlar = x.Mesajlars.Where(x => x.Gonderici == sessionveri).ToList();
                var gelensayısı = x.Mesajlars.Count(x => x.Gonderici == sessionveri).ToString();
                ViewBag.d2 = gelensayısı;
                return View(mesajlar);
                return View();
        }
        [HttpGet]
        public ActionResult MesajGonder()
        {
            var sessionveri = HttpContext.Session.GetString("Mail");

            var mesajlar = x.Mesajlars.Where(x => x.Gonderici == sessionveri).ToList();
            var gelensayısı = x.Mesajlars.Count(x => x.Gonderici == sessionveri).ToString();
            ViewBag.d2 = gelensayısı;
            return View();
        }
        [HttpPost]
        public ActionResult MesajGonder(Mesajlar mj)
        {
            var sessionveri = HttpContext.Session.GetString("Mail");
            mj.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            mj.Gonderici = sessionveri;
            x.Mesajlars.Add(mj);
            x.SaveChanges();
            return View();
        }
        public ActionResult KargoTakip( string p)
        {
            var kargo = from y in x.KargoDetays select y;
            
                kargo = kargo.Where(y => y.TakipKodu.Contains(p));
            

            return View(kargo.ToList());

        }
    }
}
