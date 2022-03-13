using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }
        public string DepartmanAd { get; set;}
        public bool Durum { get; set; }

        public ICollection<Personel>Personels { get; set; }
    }
}
