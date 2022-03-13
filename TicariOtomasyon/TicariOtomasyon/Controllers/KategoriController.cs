using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var liste = x.Kategoris.ToList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKategori(Kategori kg)
        {
            x.Kategoris.Add(kg);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KategoriSil(int id)
        {
            var sil = x.Kategoris.Find(id);
            x.Kategoris.Remove(sil);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KategoriGetir(int id)
        {
            var getir = x.Kategoris.Find(id);
            return View("KategoriGetir",getir);
        }
        public IActionResult KategoriGüncelle(Kategori kg)
        {
            var gunc = x.Kategoris.Find(kg.KategoriId);
            gunc.KategoriAd = kg.KategoriAd;
            x.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
