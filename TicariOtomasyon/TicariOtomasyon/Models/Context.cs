using Microsoft.EntityFrameworkCore;

namespace TicariOtomasyon.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S9UV1QU\\BERAT; database=ticari_otomasyon; integrated security=true;");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cari> Caris { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<FaturaKalem> FaturaKalems { get; set; }
        public DbSet<Faturalar> Faturalar { get; set; }
        public DbSet<Gider> Giders { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<SatısHareket> SatısHarekets { get; set; }
        public DbSet<Ürünler> Urunlers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Detay> Detays { get; set; }
        public DbSet<Yapılcaklar> Yapılcaklars { get; set; }
        public DbSet<KargoDetay> KargoDetays { get; set; }
        public DbSet<KargoTakip>KargoTakips { get; set; }
        public DbSet<Mesajlar>Mesajlars { get; set; }
    }
    
}
