using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class SatısHareket
    {
        [Key]
        public int SatısId { get; set; }
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }

        public virtual Ürünler Ürünler { get; set; }
        public  virtual Cari Cari { get; set; }
        public   virtual Personel Personel { get; set; }

        public int ÜrünId { get; set; }
        public int CariId { get; set; }
        public int PersonelId { get; set; }
    }
}
