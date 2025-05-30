using Microsoft.EntityFrameworkCore;
using PlakDukkaniYonetimi.Core.Helpers;
using PlakDukkaniYonetimi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYonetimi.Core.Context
{
    public class PlakDukkaniContext : DbContext
    {
        public DbSet<Yonetici> Yoneticiler { get; set; }
        public DbSet<Album> Albumler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DENIZ\\SQLEXPRESS;Database=PlakDukkaniYonetimiDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yonetici>().HasData(
                 new Yonetici
                 {
                     Id = 1,
                     KullaniciAdi = "admin",
                     Sifre = HashSifre.SifreHashle("admin")
                 });

            modelBuilder.Entity<Album>().HasData(
                new Album { Id = 1, AlbumAdi = "Opus Eponymous", Sanatci = "Ghost", CikisTarihi = new DateTime(2010, 10, 18), Fiyat = 120, IndirimOrani = null, SatisDevamMi = false },
                new Album { Id = 2, AlbumAdi = "Infestissumam", Sanatci = "Ghost", CikisTarihi = new DateTime(2013, 4, 10), Fiyat = 130, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 3, AlbumAdi = "Meliora", Sanatci = "Ghost", CikisTarihi = new DateTime(2015, 8, 21), Fiyat = 140, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 4, AlbumAdi = "Prequelle", Sanatci = "Ghost", CikisTarihi = new DateTime(2018, 6, 1), Fiyat = 150, IndirimOrani = 10, SatisDevamMi = true },
                new Album { Id = 5, AlbumAdi = "Impera", Sanatci = "Ghost", CikisTarihi = new DateTime(2022, 3, 11), Fiyat = 160, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 6, AlbumAdi = "Rite Here Rite Now", Sanatci = "Ghost", CikisTarihi = new DateTime(2024, 7, 26), Fiyat = 170, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 7, AlbumAdi = "The Frail Tide", Sanatci = "Be'lakor", CikisTarihi = new DateTime(2007, 4, 14), Fiyat = 110, IndirimOrani = null, SatisDevamMi = false },
                new Album { Id = 8, AlbumAdi = "Stone's Reach", Sanatci = "Be'lakor", CikisTarihi = new DateTime(2009, 6, 20), Fiyat = 120, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 9, AlbumAdi = "Of Breath and Bone", Sanatci = "Be'lakor", CikisTarihi = new DateTime(2012, 5, 25), Fiyat = 130, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 10, AlbumAdi = "Vessels", Sanatci = "Be'lakor", CikisTarihi = new DateTime(2016, 8, 26), Fiyat = 140, IndirimOrani = 10, SatisDevamMi = true },
                new Album { Id = 11, AlbumAdi = "Coherence", Sanatci = "Be'lakor", CikisTarihi = new DateTime(2021, 10, 29), Fiyat = 150, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 12, AlbumAdi = "Väsen", Sanatci = "Be'lakor", CikisTarihi = new DateTime(2024, 11, 29), Fiyat = 160, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 13, AlbumAdi = "Lunar Strain", Sanatci = "In Flames", CikisTarihi = new DateTime(1994, 4, 1), Fiyat = 100, IndirimOrani = null, SatisDevamMi = false },
                new Album { Id = 14, AlbumAdi = "The Jester Race", Sanatci = "In Flames", CikisTarihi = new DateTime(1996, 2, 20), Fiyat = 110, IndirimOrani = null, SatisDevamMi = false },
                new Album { Id = 15, AlbumAdi = "Whoracle", Sanatci = "In Flames", CikisTarihi = new DateTime(1997, 10, 27), Fiyat = 120, IndirimOrani = null, SatisDevamMi = false },
                new Album { Id = 16, AlbumAdi = "Colony", Sanatci = "In Flames", CikisTarihi = new DateTime(1999, 5, 31), Fiyat = 130, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 17, AlbumAdi = "Clayman", Sanatci = "In Flames", CikisTarihi = new DateTime(2000, 7, 3), Fiyat = 140, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 18, AlbumAdi = "Reroute to Remain", Sanatci = "In Flames", CikisTarihi = new DateTime(2002, 9, 2), Fiyat = 150, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 19, AlbumAdi = "Soundtrack to Your Escape", Sanatci = "In Flames", CikisTarihi = new DateTime(2004, 3, 29), Fiyat = 160, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 20, AlbumAdi = "Come Clarity", Sanatci = "In Flames", CikisTarihi = new DateTime(2006, 2, 3), Fiyat = 170, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 21, AlbumAdi = "A Sense of Purpose", Sanatci = "In Flames", CikisTarihi = new DateTime(2008, 4, 1), Fiyat = 180, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 22, AlbumAdi = "Sounds of a Playground Fading", Sanatci = "In Flames", CikisTarihi = new DateTime(2011, 6, 15), Fiyat = 190, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 23, AlbumAdi = "Siren Charms", Sanatci = "In Flames", CikisTarihi = new DateTime(2014, 9, 9), Fiyat = 200, IndirimOrani = 10, SatisDevamMi = true },
                new Album { Id = 24, AlbumAdi = "Battles", Sanatci = "In Flames", CikisTarihi = new DateTime(2016, 11, 11), Fiyat = 190, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 25, AlbumAdi = "I, the Mask", Sanatci = "In Flames", CikisTarihi = new DateTime(2019, 3, 1), Fiyat = 180, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 26, AlbumAdi = "Foregone", Sanatci = "In Flames", CikisTarihi = new DateTime(2023, 2, 10), Fiyat = 170, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 27, AlbumAdi = "Dance of December Souls", Sanatci = "Katatonia", CikisTarihi = new DateTime(1993, 12, 14), Fiyat = 100, IndirimOrani = null, SatisDevamMi = false },
                new Album { Id = 28, AlbumAdi = "Brave Murder Day", Sanatci = "Katatonia", CikisTarihi = new DateTime(1996, 8, 1), Fiyat = 110, IndirimOrani = null, SatisDevamMi = false },
                new Album { Id = 29, AlbumAdi = "Discouraged Ones", Sanatci = "Katatonia", CikisTarihi = new DateTime(1998, 4, 27), Fiyat = 120, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 30, AlbumAdi = "Tonight's Decision", Sanatci = "Katatonia", CikisTarihi = new DateTime(1999, 8, 31), Fiyat = 130, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 31, AlbumAdi = "Last Fair Deal Gone Down", Sanatci = "Katatonia", CikisTarihi = new DateTime(2001, 5, 8), Fiyat = 140, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 32, AlbumAdi = "Viva Emptiness", Sanatci = "Katatonia", CikisTarihi = new DateTime(2003, 3, 24), Fiyat = 150, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 33, AlbumAdi = "The Great Cold Distance", Sanatci = "Katatonia", CikisTarihi = new DateTime(2006, 3, 13), Fiyat = 160, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 34, AlbumAdi = "Night Is the New Day", Sanatci = "Katatonia", CikisTarihi = new DateTime(2009, 11, 2), Fiyat = 170, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 35, AlbumAdi = "Dead End Kings", Sanatci = "Katatonia", CikisTarihi = new DateTime(2012, 8, 27), Fiyat = 180, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 36, AlbumAdi = "The Fall of Hearts", Sanatci = "Katatonia", CikisTarihi = new DateTime(2016, 5, 20), Fiyat = 190, IndirimOrani = 10, SatisDevamMi = true },
                new Album { Id = 37, AlbumAdi = "City Burials", Sanatci = "Katatonia", CikisTarihi = new DateTime(2020, 4, 24), Fiyat = 200, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 38, AlbumAdi = "Sky Void of Stars", Sanatci = "Katatonia", CikisTarihi = new DateTime(2023, 1, 20), Fiyat = 190, IndirimOrani = null, SatisDevamMi = true },
                new Album { Id = 39, AlbumAdi = "Nightmares as Extensions of the Waking State", Sanatci = "Katatonia", CikisTarihi = new DateTime(2025, 6, 6), Fiyat = 180, IndirimOrani = null, SatisDevamMi = true }
            );
        }
    }
}
