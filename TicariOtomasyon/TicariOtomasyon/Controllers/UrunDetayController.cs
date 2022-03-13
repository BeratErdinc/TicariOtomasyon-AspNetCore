using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var degerler = x.Urunlers.Where(x => x.UrunId == 1).ToList();
            UrunDetayAynılıst s = new UrunDetayAynılıst();
            s.Deger1=x.Urunlers.Where(x=>x.UrunId==1).ToList();
            s.Deger2 = x.Detays.Where(y => y.DetayId == 1).ToList();
            return View(s);
        }
    }
}
