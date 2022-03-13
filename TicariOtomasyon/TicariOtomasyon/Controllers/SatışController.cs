using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class SatışController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var liste = x.SatısHarekets.Include(x => x.Cari).Include(x => x.Personel).Include(x => x.Ürünler).ToList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult SatışEkle()
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

            ViewBag.dgr3= personel;



            List<SelectListItem> fiyat = (from i in x.Urunlers.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.SatısFiyat.ToString(),
                                                 Value = i.UrunId.ToString()
                                          }

                                 ).ToList();

            ViewBag.dgr4 = fiyat;





            return View();
        }
        [HttpPost]
        public IActionResult SatışEkle(SatısHareket sh)
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
