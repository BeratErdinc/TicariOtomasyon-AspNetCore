using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class DepartmanController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var liste= x.Departmans.ToList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DepartmanEkle(Departman dp)
        {
            x.Departmans.Add(dp);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanSil(int id)
        {
            var sil = x.Departmans.Find(id);
            x.Departmans.Remove(sil);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanDetay(int id)
        {
            var degerler =x.Personels.Where(x=>x.DepartmanId == id).ToList();   
            return View(degerler);
        }
        public IActionResult DepartmanPersonelSatış(int id)
        {
            var degerler = x.SatısHarekets.Include(x => x.Cari).Include(x => x.Ürünler).Include(x => x.Personel).Where(x => x.PersonelId == id).ToList();
            return View(degerler);
        }
    }
}
