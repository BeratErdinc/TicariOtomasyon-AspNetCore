using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class GaleriController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var degerler = x.Urunlers.ToList();
            return View(degerler);
        }
    }
}
