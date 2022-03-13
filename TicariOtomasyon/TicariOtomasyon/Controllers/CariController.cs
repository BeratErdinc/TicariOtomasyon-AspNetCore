using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class CariController : Controller
    {
        Context x = new Context();
        

        public IActionResult Index()
        {
            var liste = x.Caris.ToList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult CariEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CariEkle(Cari ch)
        {
            x.Caris.Add(ch);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult CariSil(int id)
        {
            var sil = x.Caris.Find(id);
            x.Caris.Remove(sil);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult CariGetir(int id)
        {
            var getir = x.Caris.Find(id);
            return View("CariGetir", getir);
        }
        public IActionResult CariGüncelle(Cari ch)
        {
            var gun = x.Caris.Find(ch.CariId);
            gun.CariAd = ch.CariAd;
            gun.CariSoyad = ch.CariSoyad;
            gun.CariMail = ch.CariMail;
            gun.CariSehir = ch.CariSehir;
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult MusteriSatıs(int id)
        {
            var degerler = x.SatısHarekets.Include(x=>x.Ürünler).Include(x=>x.Personel).Where(x => x.CariId == id).ToList();
            return View(degerler);
        }
    }
}
