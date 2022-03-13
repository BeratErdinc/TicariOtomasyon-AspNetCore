using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Gider
    {
        [Key]
        public int GiderId { get; set; }
        public string Acıklama { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
    }
}
