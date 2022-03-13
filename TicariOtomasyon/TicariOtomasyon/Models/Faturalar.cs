using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Faturalar
    {
        [Key]
        public int FaturaId { get; set; }
        public char FaturaSeriNo { get; set; }
        public string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }
        public string VergiDairesi { get; set; }
        public string Saat { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }
        public decimal Toplam { get; set; }

        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}
