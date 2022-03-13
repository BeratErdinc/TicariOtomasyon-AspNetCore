using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string KullanıcıAd { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }

    }
}
