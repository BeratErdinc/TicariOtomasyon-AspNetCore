using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Mesajlar
    {
        [Key]
        public int MesajId { get; set; }
        public string Gonderici { get; set; }
        public string Alıcı { get; set; }
        public string Konu { get; set; }
        public string İcerik { get; set; }
        public DateTime Tarih { get; set; }
    }
}
