using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Cari
    {
        [Key]
        public int CariId { get; set; }
        public string CariAd { get; set; }
        public string CariSoyad { get; set; }
        public string CariSehir { get; set; }
        public string CariMail { get; set; }
        public string CariSifre { get; set; }

        public ICollection<SatısHareket> SatısHareket { get; set; }

    }
}
