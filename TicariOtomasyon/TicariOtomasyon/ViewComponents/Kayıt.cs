using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.ViewComponents
{
    public class Kayıt:ViewComponent
    {
        Context x = new Context();
      
        public IViewComponentResult Invoke(Cari ct)
        {
            x.Caris.Add(ct);
            x.SaveChanges();
            return View();
        }

        //[HttpGet]
        //public IViewComponentResult Log()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IViewComponentResult Log(Cari cr)
        //{
        //    x.Caris.Add(cr);
        //    x.SaveChanges();
        //    return View();
        //}

    }
}
