using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get;set; }

        public ICollection<Ürünler> Uruns { get; set; }

    }
}
