using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Ürünler
    {
        [Key]
        public int UrunId { get;set; }
        public  string UrunAd { get; set; }
        public string Marka { get; set; }
        public short Stok { get; set; }
        public decimal AlısFiyat { get;set;}
        public decimal SatısFiyat { get; set; }
        public bool Durum { get; set; }
        public string Gorsel { get; set; }

        public  virtual Kategori Kategori { get; set; }
        public int KategoriId { get; set; } 
        public ICollection<SatısHareket>SatısHareket { get; set; }

        
    }
}
