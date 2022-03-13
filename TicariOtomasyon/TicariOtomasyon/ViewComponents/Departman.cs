using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models;

namespace TicariOtomasyon.ViewComponents
{
    public class Departman:ViewComponent
    {
        Context x = new Context();
        public IViewComponentResult Invoke()
        {
            var sorgu2 = from c in x.Personels
                         group c by c.DepartmanId into g
                         select new SınıfGrup2
                         {
                             Departman = g.Key,
                             sayı = g.Count()
                         };
            return View(sorgu2.ToList());
        }
    }
}
