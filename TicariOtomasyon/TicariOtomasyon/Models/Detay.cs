using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models
{
    public class Detay
    {
        [Key]
        public int DetayId { get; set; }
        public string UrunAd { get; set; }
        public string UrunBılgı { get; set; }   
    }
}
