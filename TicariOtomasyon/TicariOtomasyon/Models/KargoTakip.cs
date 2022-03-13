using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class KargoTakip
    {
        [Key]
        public int KargoTakipId { get; set; }
        public string TakipNo { get; set; }
        public string Acıklama { get; set; }
        public DateTime TarihZaman { get; set; }
    }
}
