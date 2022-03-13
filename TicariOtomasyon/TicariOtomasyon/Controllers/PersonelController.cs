using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class PersonelController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var liste = x.Personels.Include(x=>x.Deparman).ToList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult PersonelEkle()
        {
            List<SelectListItem> urun = (from i in x.Departmans.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.DepartmanAd,
                                             Value = i.DepartmanId.ToString()
                                         }

                                        ).ToList();

            ViewBag.dgr = urun;



            return View();
        }
        [HttpPost]
        public IActionResult PersonelEkle(Personel per)
        {
            x.Personels.Add(per);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonelGetir(int id)
        {
            List<SelectListItem> urun = (from i in x.Departmans.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.DepartmanAd,
                                             Value = i.DepartmanId.ToString()
                                         }

                                       ).ToList();

            ViewBag.dgr = urun;
            var getir = x.Personels.Find(id);
            return View("PersonelGetir", getir);
        }
        public IActionResult PersonelGüncelle(Personel pp)
        {
            var gunc = x.Personels.Find(pp.PersonelId);
            gunc.PersonelAd = pp.PersonelAd;
            gunc.PersonelSoyad = pp.PersonelSoyad;
            gunc.PersonelGorsel = pp.PersonelGorsel;
            gunc.DepartmanId = pp.DepartmanId;
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonelListesi()
        {
            var liste = x.Personels.ToList();
            return View(liste);
        }
    }
}
