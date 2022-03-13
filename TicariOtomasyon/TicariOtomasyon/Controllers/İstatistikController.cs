using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class İstatistikController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var deger1 = x.Caris.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = x.Urunlers.Count().ToString();
            ViewBag.d2 = deger2;
            var deger3=x.Personels.Count().ToString();
            ViewBag.d3 = deger3;
            var deger4=x.Kategoris.Count().ToString();
            ViewBag.d4 = deger4;
            var deger5 = x.Urunlers.Sum(x => x.Stok).ToString();
            ViewBag.d5 = deger5;
            var deger6 = (from y in x.Urunlers select y.Marka).Distinct().Count().ToString();
            ViewBag.d6 = deger6;
            var deger7 = x.Urunlers.Count(x => x.Stok <= 20).ToString();
            ViewBag.d7= deger7;
            var deger8 = (from y in x.Urunlers orderby y.SatısFiyat descending select y.UrunAd).FirstOrDefault();
            ViewBag.d8 = deger8;
            return View();
        }
        public IActionResult SımpleTable()
        {
            var sorgu = from c in x.Caris group c by c.CariSehir into g select new SınıfGrup
            {
                Sehir = g.Key,
                Sayi = g.Count()
             };
            return View(sorgu.ToList()); 
        }
    
    }
}
