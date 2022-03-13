using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class KargoDetay
    {

        [Key]
        public int KargoDetayId{ get; set; }
        public string Acıklama { get; set; }
        public string TakipKodu{ get; set; }
        public string Personel { get; set; }
        public string Alıcı { get; set; }
        public DateTime Tarih { get; set; }
    }
}
