﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicariOtomasyon.Models;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TicariOtomasyon.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("KullanıcıAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yetki")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Cari", b =>
                {
                    b.Property<int>("CariId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CariId"), 1L, 1);

                    b.Property<string>("CariAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CariMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CariSehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CariSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CariSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CariId");

                    b.ToTable("Caris");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Departman", b =>
                {
                    b.Property<int>("DepartmanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmanId"), 1L, 1);

                    b.Property<string>("DepartmanAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("DepartmanId");

                    b.ToTable("Departmans");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Detay", b =>
                {
                    b.Property<int>("DetayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetayId"), 1L, 1);

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunBılgı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetayId");

                    b.ToTable("Detays");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.FaturaKalem", b =>
                {
                    b.Property<int>("FaturaKalemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaKalemId"), 1L, 1);

                    b.Property<string>("Acıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FaturaId")
                        .HasColumnType("int");

                    b.Property<int>("FaturalarFaturaId")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FaturaKalemId");

                    b.HasIndex("FaturalarFaturaId");

                    b.ToTable("FaturaKalems");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Faturalar", b =>
                {
                    b.Property<int>("FaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaId"), 1L, 1);

                    b.Property<string>("FaturaSeriNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("FaturaSıraNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Saat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeslimAlan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeslimEden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Toplam")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FaturaId");

                    b.ToTable("Faturalar");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Gider", b =>
                {
                    b.Property<int>("GiderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GiderId"), 1L, 1);

                    b.Property<string>("Acıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("GiderId");

                    b.ToTable("Giders");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.KargoDetay", b =>
                {
                    b.Property<int>("KargoDetayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KargoDetayId"), 1L, 1);

                    b.Property<string>("Acıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alıcı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TakipKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("KargoDetayId");

                    b.ToTable("KargoDetays");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.KargoTakip", b =>
                {
                    b.Property<int>("KargoTakipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KargoTakipId"), 1L, 1);

                    b.Property<string>("Acıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TakipNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TarihZaman")
                        .HasColumnType("datetime2");

                    b.HasKey("KargoTakipId");

                    b.ToTable("KargoTakips");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriId"), 1L, 1);

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Mesajlar", b =>
                {
                    b.Property<int>("MesajId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MesajId"), 1L, 1);

                    b.Property<string>("Alıcı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gonderici")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("İcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MesajId");

                    b.ToTable("Mesajlars");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelId"), 1L, 1);

                    b.Property<int>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonelGorsel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonelSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelId");

                    b.HasIndex("DepartmanId");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.SatısHareket", b =>
                {
                    b.Property<int>("SatısId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SatısId"), 1L, 1);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("CariId")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ÜrünId")
                        .HasColumnType("int");

                    b.Property<int>("ÜrünlerUrunId")
                        .HasColumnType("int");

                    b.HasKey("SatısId");

                    b.HasIndex("CariId");

                    b.HasIndex("PersonelId");

                    b.HasIndex("ÜrünlerUrunId");

                    b.ToTable("SatısHarekets");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Ürünler", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunId"), 1L, 1);

                    b.Property<decimal>("AlısFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Gorsel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SatısFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("Stok")
                        .HasColumnType("smallint");

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrunId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunlers");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Yapılcaklar", b =>
                {
                    b.Property<int>("YapılcakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YapılcakId"), 1L, 1);

                    b.Property<string>("Baslık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("YapılcakId");

                    b.ToTable("Yapılcaklars");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.FaturaKalem", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Faturalar", "Faturalar")
                        .WithMany("FaturaKalems")
                        .HasForeignKey("FaturalarFaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faturalar");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Personel", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Departman", "Deparman")
                        .WithMany("Personels")
                        .HasForeignKey("DepartmanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deparman");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.SatısHareket", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Cari", "Cari")
                        .WithMany("SatısHareket")
                        .HasForeignKey("CariId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicariOtomasyon.Models.Personel", "Personel")
                        .WithMany("SatısHareket")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicariOtomasyon.Models.Ürünler", "Ürünler")
                        .WithMany("SatısHareket")
                        .HasForeignKey("ÜrünlerUrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cari");

                    b.Navigation("Personel");

                    b.Navigation("Ürünler");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Ürünler", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Kategori", "Kategori")
                        .WithMany("Uruns")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Cari", b =>
                {
                    b.Navigation("SatısHareket");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Departman", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Faturalar", b =>
                {
                    b.Navigation("FaturaKalems");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Kategori", b =>
                {
                    b.Navigation("Uruns");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Personel", b =>
                {
                    b.Navigation("SatısHareket");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Ürünler", b =>
                {
                    b.Navigation("SatısHareket");
                });
#pragma warning restore 612, 618
        }
    }
}
