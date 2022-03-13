using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Personel
    {
        [Key]
        public int PersonelId { get;set; }
        public string PersonelAd { get;set; }   
        public string PersonelSoyad { get; set; }
        public string PersonelGorsel { get; set; }

        public ICollection<SatısHareket> SatısHareket { get; set; }
        public virtual Departman Deparman { get; set; }
        public int DepartmanId { get; set; }
    }
}
