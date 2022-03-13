using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.Controllers
{
    public class YapılcaklarController : Controller
    {
        Context x = new Context();
        public IActionResult Index()
        {
            var yapılıcak = x.Yapılcaklars.ToList();
            return View(yapılıcak);
        }
    }
}
