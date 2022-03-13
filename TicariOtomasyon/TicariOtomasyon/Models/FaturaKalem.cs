using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class FaturaKalem
    {
        [Key]
        public int FaturaKalemId { get; set; }
        public string Acıklama { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }
        public virtual Faturalar Faturalar { get; set; }
        public int FaturaId { get; set;  }
    }
}
