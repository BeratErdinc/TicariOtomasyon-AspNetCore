using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class ÜrünController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var liste = x.Urunlers.Include(x=>x.Kategori).Where(x=>x.Durum==true).ToList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult ÜrünEkle()
        {

        
                List<SelectListItem> urun = (from i in x.Kategoris.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KategoriAd,
                                                 Value = i.KategoriId.ToString()
                                             }

                                          ).ToList();

                ViewBag.dgr = urun;
                return View();


           
               
        }
        [HttpPost]
        public IActionResult ÜrünEkle(Ürünler ür)
        {
            
            x.Urunlers.Add(ür);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ÜrünSil(int id)
        {
            var sil = x.Urunlers.Find(id);
            x.Urunlers.Remove(sil);
                x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ÜrünDüzenle(int id)
        {
            List<SelectListItem> urun = (from i in x.Kategoris.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.KategoriAd,
                                             Value = i.KategoriId.ToString()
                                         }

                                        ).ToList();

            ViewBag.dgr = urun;
            var per = x.Urunlers.Find(id);
            return View("ÜrünDüzenle", per);
        }
        public IActionResult ÜrünGüncelle(Ürünler ürn)
        {
            var vs = x.Urunlers.Find(ürn.UrunId);
            vs.Marka = ürn.Marka;
            vs.SatısFiyat = ürn.SatısFiyat;
            vs.AlısFiyat = ürn.AlısFiyat;
            vs.Stok = ürn.Stok;
            vs.UrunAd = ürn.UrunAd;
            vs.Gorsel = ürn.Gorsel;
            vs.KategoriId = ürn.KategoriId;
           
            x.SaveChanges();
            return RedirectToAction("Index");

                
        }
        [HttpGet]
        public ActionResult SatısYap(int id)
        {
            
                List<SelectListItem> urun = (from i in x.Urunlers.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.UrunAd,
                                                 Value = i.UrunId.ToString()
                                             }

                                       ).ToList();

                ViewBag.dgr = urun;



                List<SelectListItem> cari = (from i in x.Caris.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.CariAd,
                                                 Value = i.CariId.ToString()
                                             }

                                       ).ToList();

                ViewBag.dgr2 = cari;


                List<SelectListItem> personel = (from i in x.Personels.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = i.PersonelAd,
                                                     Value = i.PersonelId.ToString()
                                                 }

                                       ).ToList();

                ViewBag.dgr3 = personel;
                var deger1 = x.Urunlers.Find(id);
                ViewBag.dgr4 = deger1.UrunId;
                ViewBag.dg5 = deger1.SatısFiyat;
                return View();
        }

        [HttpPost]
        public ActionResult SatısYap(SatısHareket sh)
        {

            var urn = x.Urunlers.Where(x => x.UrunId == sh.Ürünler.UrunId).FirstOrDefault();
            sh.Ürünler = urn;
            var perso = x.Personels.Where(z => z.PersonelId == sh.Personel.PersonelId).FirstOrDefault();
            sh.Personel = perso;
            var cari = x.Caris.Where(k => k.CariId == sh.Cari.CariId).FirstOrDefault();
            sh.Cari = cari;
            x.SatısHarekets.Add(sh);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
