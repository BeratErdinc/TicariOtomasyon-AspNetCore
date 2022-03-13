using Microsoft.AspNetCore.Mvc;

namespace TicariOtomasyon.Controllers
{
    public class MesajlarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
