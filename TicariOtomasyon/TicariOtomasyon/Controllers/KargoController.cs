using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class KargoController : Controller
    {
        Context x = new Context();
        public IActionResult Index(string p)
        {
            var kargo = from y in x.KargoDetays select y;
            if (!string.IsNullOrEmpty(p))
            {
                kargo = kargo.Where(y => y.TakipKodu.Contains(p));
            }

            return View(kargo.ToList());
           
        }

        [HttpGet]
        public IActionResult KargoEkle()
        {
            Random rdr = new Random();
            string[] karakterler = { "A", "B", "C", "D", "T", "Y" };
            int k1, k2, k3;
            k1 = rdr.Next(0, 4);
            k2 = rdr.Next(0, 4);
            k3 = rdr.Next(0, 4);
            int s1, s2, s3;
            s1=rdr.Next(100,1000);
            s2=rdr.Next(100,1000);
            s3=rdr.Next(100,1000);
            string kod = s1.ToString() + karakterler[k1] + s2 + karakterler[k2] + s3 + karakterler[k3];
            ViewBag.takipkod = kod;
            return View();
        }
        [HttpPost]
        public IActionResult KargoEkle(KargoDetay dt)
        {
            x.KargoDetays.Add(dt);
            x.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KargoDetay(string id)
        {
            var degerler = x.KargoTakips.Where(x => x.TakipNo == id).ToList();
            return View(degerler);
        }
    }
}
