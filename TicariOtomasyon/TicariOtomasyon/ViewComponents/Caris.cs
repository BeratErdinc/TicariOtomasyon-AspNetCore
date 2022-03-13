using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.ViewComponents
{
    public class Caris:ViewComponent
    {
        Context x = new Context();
        public IViewComponentResult Invoke()
        {
            var sırala = x.Caris.ToList();
            return View(sırala);
        }
    }
}
