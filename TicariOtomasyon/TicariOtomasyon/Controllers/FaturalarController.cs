using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class FaturalarController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var liste = x.Faturalar.ToList();

            return View(liste);
        }
        [HttpGet]
        public IActionResult FaturaEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FaturaEkle(Faturalar f)
        {
            x.Faturalar.Add(f);
            x.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Getir(int id)
        {
            var getir = x.Faturalar.Find(id);
            return View("Getir", getir);
        }
        public IActionResult FaturaGüncelle(Faturalar f)
        {
            var gunc = x.Faturalar.Find(f.FaturaId);
            gunc.FaturaSeriNo = f.FaturaSeriNo;
            gunc.FaturaSıraNo = f.FaturaSıraNo;
            gunc.Saat = f.Saat;
            gunc.Tarih = f.Tarih;
            gunc.TeslimAlan = f.TeslimAlan;
            gunc.TeslimEden = f.TeslimEden;
            gunc.VergiDairesi = f.VergiDairesi;
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult FaturaDetay()
        {
            return View();
        }
    }
}
