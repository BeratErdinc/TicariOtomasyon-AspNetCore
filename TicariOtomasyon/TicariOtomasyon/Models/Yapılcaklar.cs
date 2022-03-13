using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Yapılcaklar
    {


        [Key]
        public int YapılcakId { get; set; }
        public string Baslık { get; set; }
        public bool Durum { get; set; }
  



    }
}
