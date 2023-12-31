﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungFit.DAL.Entities;
using YoungFit.DAL.Enums;

namespace YoungFit.DAL.Context
{
    public class UygulamaDbContext : DbContext
    {
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<KullaniciYemek> KullaniciYemekler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=YoungFitDb;Trusted_Connection=True;TrustServerCertificate=True");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yemek>().HasData(
                new Yemek { Id = 1, YemekAdi = "Somon", OlcuBirimi = OlcuBirimi.Gram, Kalori = 200 },
                new Yemek { Id = 2, YemekAdi = "Ahtapot", OlcuBirimi = OlcuBirimi.Adet, Kalori = 150 },
                new Yemek { Id = 3, YemekAdi = "Alabalık", OlcuBirimi = OlcuBirimi.Gram, Kalori = 180 },
                new Yemek { Id = 4, YemekAdi = "Barbun", OlcuBirimi = OlcuBirimi.Gram, Kalori = 160 },
                new Yemek { Id = 5, YemekAdi = "Çipura", OlcuBirimi = OlcuBirimi.Gram, Kalori = 170 },
                new Yemek { Id = 6, YemekAdi = "Dil Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 140 },
                new Yemek { Id = 7, YemekAdi = "Izgara Hamsi", OlcuBirimi = OlcuBirimi.Gram, Kalori = 120 },
                new Yemek { Id = 8, YemekAdi = "Kızartma Hamsi", OlcuBirimi = OlcuBirimi.Gram, Kalori = 130 },
                new Yemek { Id = 9, YemekAdi = "Havyar", OlcuBirimi = OlcuBirimi.Gram, Kalori = 250 },
                new Yemek { Id = 10, YemekAdi = "Istakoz", OlcuBirimi = OlcuBirimi.Adet, Kalori = 220 },
                new Yemek { Id = 11, YemekAdi = "İstavrit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 180 },
                new Yemek { Id = 12, YemekAdi = "İstiridye", OlcuBirimi = OlcuBirimi.Adet, Kalori = 200 },
                new Yemek { Id = 13, YemekAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 150 },
                new Yemek { Id = 14, YemekAdi = "Kalkan Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 190 },
                new Yemek { Id = 15, YemekAdi = "Karides Güveç", OlcuBirimi = OlcuBirimi.Gram, Kalori = 160 },
                new Yemek { Id = 16, YemekAdi = "Tereyağda Karides", OlcuBirimi = OlcuBirimi.Gram, Kalori = 170 },
                new Yemek { Id = 17, YemekAdi = "Kefal Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 160 },
                new Yemek { Id = 18, YemekAdi = "Kılıç Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 180 },
                new Yemek { Id = 19, YemekAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 150 },
                new Yemek { Id = 20, YemekAdi = "Lüfer", OlcuBirimi = OlcuBirimi.Gram, Kalori = 170 },
                new Yemek { Id = 21, YemekAdi = "Mezgit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 160 },
                new Yemek { Id = 22, YemekAdi = "Midye Dolma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 130 },
                new Yemek { Id = 23, YemekAdi = "Midye Tava", OlcuBirimi = OlcuBirimi.Gram, Kalori = 140 },
                new Yemek { Id = 24, YemekAdi = "Palamut", OlcuBirimi = OlcuBirimi.Gram, Kalori = 180 },
                new Yemek { Id = 25, YemekAdi = "Sardalya", OlcuBirimi = OlcuBirimi.Gram, Kalori = 160 },
                new Yemek { Id = 26, YemekAdi = "Sazan", OlcuBirimi = OlcuBirimi.Gram, Kalori = 170 },
                new Yemek { Id = 27, YemekAdi = "Deniz Tarağı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 210 },
                new Yemek { Id = 28, YemekAdi = "Tekir", OlcuBirimi = OlcuBirimi.Gram, Kalori = 140 },
                new Yemek { Id = 29, YemekAdi = "Ton Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 200 },
                new Yemek { Id = 30, YemekAdi = "Sushi", OlcuBirimi = OlcuBirimi.Adet, Kalori = 250 },
                new Yemek { Id = 31, YemekAdi = "Haşlanmış Tavuk Göğsü", OlcuBirimi = OlcuBirimi.Gram, Kalori = 150 },
                new Yemek { Id = 32, YemekAdi = "Pişmiş Tavuk Eti", OlcuBirimi = OlcuBirimi.Gram, Kalori = 200 },
                new Yemek { Id = 33, YemekAdi = "Kızarmış Tavuk Kanadı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 180 },
                new Yemek { Id = 34, YemekAdi = "Kızarmış Tavuk But", OlcuBirimi = OlcuBirimi.Gram, Kalori = 220 },
                new Yemek { Id = 35, YemekAdi = "Haşlanmış Tavuk But", OlcuBirimi = OlcuBirimi.Gram, Kalori = 200 },
                new Yemek { Id = 36, YemekAdi = "Tavuk Köftesi", OlcuBirimi = OlcuBirimi.Gram, Kalori = 150 },
                new Yemek { Id = 37, YemekAdi = "Tavuk Ciğeri", OlcuBirimi = OlcuBirimi.Gram, Kalori = 190 },
                new Yemek { Id = 38, YemekAdi = "Ahududu", OlcuBirimi = OlcuBirimi.Gram, Kalori = 50 },
                new Yemek { Id = 39, YemekAdi = "Böğürtlen", OlcuBirimi = OlcuBirimi.Gram, Kalori = 40 },
                new Yemek { Id = 40, YemekAdi = "Yeşil Erik", OlcuBirimi = OlcuBirimi.Adet, Kalori = 30 },
                new Yemek { Id = 41, YemekAdi = "İncir", OlcuBirimi = OlcuBirimi.Adet, Kalori = 25 },
                new Yemek { Id = 42, YemekAdi = "Dut", OlcuBirimi = OlcuBirimi.Gram, Kalori = 20 },
                new Yemek { Id = 43, YemekAdi = "Üzüm", OlcuBirimi = OlcuBirimi.Gram, Kalori = 35 },
                new Yemek { Id = 44, YemekAdi = "Nar", OlcuBirimi = OlcuBirimi.Adet, Kalori = 40 },
                new Yemek { Id = 45, YemekAdi = "Şeftali", OlcuBirimi = OlcuBirimi.Adet, Kalori = 30 },
                new Yemek { Id = 46, YemekAdi = "Limon", OlcuBirimi = OlcuBirimi.Adet, Kalori = 15 },
                new Yemek { Id = 47, YemekAdi = "Kırmızı Erik", OlcuBirimi = OlcuBirimi.Adet, Kalori = 30 },
                new Yemek { Id = 48, YemekAdi = "Sütlaç", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 200 },
                new Yemek { Id = 49, YemekAdi = "Kazandibi", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 220 },
                new Yemek { Id = 50, YemekAdi = "Magnolia", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 180 },
                new Yemek { Id = 51, YemekAdi = "Tiramisu", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 250 },
                new Yemek { Id = 52, YemekAdi = "Cheesecake", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 280 },
                new Yemek { Id = 53, YemekAdi = "Güllaç", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 190 },
                new Yemek { Id = 54, YemekAdi = "Tavuk Göğsü Tatlısı", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 180 },
                new Yemek { Id = 55, YemekAdi = "Muhallebi", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 200 },
                new Yemek { Id = 56, YemekAdi = "Puding", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 160 },
                new Yemek { Id = 57, YemekAdi = "Supangle", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 220 },
                new Yemek { Id = 58, YemekAdi = "Trileçe", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 240 },
                new Yemek { Id = 59, YemekAdi = "Höşmerim", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 180 },
                new Yemek { Id = 60, YemekAdi = "Keşkül", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 210 },
                new Yemek { Id = 61, YemekAdi = "Aşure", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 250 },
                new Yemek { Id = 62, YemekAdi = "Profiterol", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 200 },
                new Yemek { Id = 63, YemekAdi = "Meyveli Dondurma", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 170 },
                new Yemek { Id = 64, YemekAdi = "Sütlü Dondurma", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 160 },
                new Yemek { Id = 65, YemekAdi = "Çikolatalı Dondurma", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 180 },
                new Yemek { Id = 66, YemekAdi = "Sütlü İrmik Tatlısı", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 190 },
                new Yemek { Id = 67, YemekAdi = "İrmik Helvası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 250 },
                new Yemek { Id = 68, YemekAdi = "Un Helvası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 280 },
                new Yemek { Id = 69, YemekAdi = "Baklava", OlcuBirimi = OlcuBirimi.Adet, Kalori = 320 },
                new Yemek { Id = 70, YemekAdi = "Kadayıf", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 280 },
                new Yemek { Id = 71, YemekAdi = "Soğuk Baklava", OlcuBirimi = OlcuBirimi.Adet, Kalori = 300 },
                new Yemek { Id = 72, YemekAdi = "Tulumba", OlcuBirimi = OlcuBirimi.Adet, Kalori = 270 },
                new Yemek { Id = 73, YemekAdi = "Kemalpaşa", OlcuBirimi = OlcuBirimi.Adet, Kalori = 240 },
                new Yemek { Id = 74, YemekAdi = "Halka Tatlısı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 280 },
                new Yemek { Id = 75, YemekAdi = "Şam Tatlısı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 290 },
                new Yemek { Id = 76, YemekAdi = "Şöbiyet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 300 },
                new Yemek { Id = 77, YemekAdi = "Künefe", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 310 },
                new Yemek { Id = 78, YemekAdi = "Şekerpare", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 260 },
                new Yemek { Id = 79, YemekAdi = "Revani", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 270 },
                new Yemek { Id = 80, YemekAdi = "Lokma Tatlısı", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 280 },
                new Yemek { Id = 81, YemekAdi = "Kalburabastı", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 290 },
                new Yemek { Id = 82, YemekAdi = "Fıstıklı Sarma Tatlısı", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 310 },
                new Yemek { Id = 83, YemekAdi = "Un Helvası", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 260 },
                new Yemek { Id = 84, YemekAdi = "San Sebastian", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 280 },
                new Yemek { Id = 85, YemekAdi = "Tam Yağlı İnek Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 150 },
                new Yemek { Id = 86, YemekAdi = "Yarım Yağlı İnek Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 120 },
                new Yemek { Id = 87, YemekAdi = "Keçi Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 140 },
                new Yemek { Id = 88, YemekAdi = "Soya Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 100 },
                new Yemek { Id = 89, YemekAdi = "Badem Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 130 },
                new Yemek { Id = 90, YemekAdi = "Beyaz Peynir", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 100 },
                new Yemek { Id = 91, YemekAdi = "Süzme Peynir", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 110 },
                new Yemek { Id = 92, YemekAdi = "Lor Peyniri", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 120 },
                new Yemek { Id = 93, YemekAdi = "Kaşar Peyniri", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 130 },
                new Yemek { Id = 94, YemekAdi = "Labne", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 140 },
                new Yemek { Id = 95, YemekAdi = "Örgü Peynir", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 150 },
                new Yemek { Id = 96, YemekAdi = "Dil Peyniri", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 160 },
                new Yemek { Id = 97, YemekAdi = "Hellim Peyniri", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 170 },            
                new Yemek { Id = 98, YemekAdi = "Kefir", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 120 },
                new Yemek { Id = 99, YemekAdi = "Yoğurt", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 130 },
                new Yemek { Id = 100, YemekAdi = "Ayran", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 100 },
                new Yemek { Id = 101, YemekAdi = "Cacık", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 110 },
                new Yemek { Id = 102, YemekAdi = "Haşlanmış Yumurta", OlcuBirimi = OlcuBirimi.Adet, Kalori = 70 },
                new Yemek { Id = 103, YemekAdi = "Omlet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 120 },
                new Yemek { Id = 104, YemekAdi = "Peynirli Omlet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 130 },
                new Yemek { Id = 105, YemekAdi = "Mantarlı Omlet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 140 },
                new Yemek { Id = 106, YemekAdi = "Menemen", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 150 },
                new Yemek { Id = 107, YemekAdi = "Sucuklu Yumurta", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 160 },
                new Yemek { Id = 108, YemekAdi = "Kuymak - Mıhlama", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 170 },
                new Yemek { Id = 109, YemekAdi = "Sucuk", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 180 },
                new Yemek { Id = 110, YemekAdi = "Sosis", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 190 },
                new Yemek { Id = 111, YemekAdi = "Dana Salam", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 200 },
                new Yemek { Id = 112, YemekAdi = "Hindi Salam", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 210 },
                new Yemek { Id = 113, YemekAdi = "Dana Jambon", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 220 },
                new Yemek { Id = 114, YemekAdi = "Hindi Jambon", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 230 },
                new Yemek { Id = 115, YemekAdi = "Piliç Jambon", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 240 },
                new Yemek { Id = 116, YemekAdi = "Hindi Füme", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 250 },
                new Yemek { Id = 117, YemekAdi = "Piliç Füme", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 260 },
                new Yemek { Id = 118, YemekAdi = "Pastırma", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 270 },
                new Yemek { Id = 119, YemekAdi = "Siyah Zeytin", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 50 },
                new Yemek { Id = 120, YemekAdi = "Yeşil Zeytin", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 60 },
                new Yemek { Id = 121, YemekAdi = "Bal", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 50 },
                new Yemek { Id = 122, YemekAdi = "Kaymak", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 60 },
                new Yemek { Id = 123, YemekAdi = "Keçi Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 70 },
                new Yemek { Id = 124, YemekAdi = "Cevizli Yaz Helvası", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 80 },
                new Yemek { Id = 125, YemekAdi = "Tahin", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 90 },
                new Yemek { Id = 126, YemekAdi = "Pekmez", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 100 },
                new Yemek { Id = 127, YemekAdi = "Tahin Pekmez", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 110 },
                new Yemek { Id = 128, YemekAdi = "Nutella", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 120 },
                new Yemek { Id = 129, YemekAdi = "Kakaolu Fındık Kreması", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 130 },
                new Yemek { Id = 130, YemekAdi = "Fındık Ezmesi", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 140 },
                new Yemek { Id = 131, YemekAdi = "Fıstık Ezmesi", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 150 },
                new Yemek { Id = 132, YemekAdi = "Haşlanmış Makarna", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 220 },
                new Yemek { Id = 133, YemekAdi = "Domatesli Makarna", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 230 },
                new Yemek { Id = 134, YemekAdi = "Spagetti Bolonez", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 240 },
                new Yemek { Id = 135, YemekAdi = "Penne Arabiata", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 250 },
                new Yemek { Id = 136, YemekAdi = "Fettucini Alfredo", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 260 },
                new Yemek { Id = 137, YemekAdi = "Lazanya", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 270 },
                new Yemek { Id = 138, YemekAdi = "Fırında Makarna", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 280 },
                new Yemek { Id = 139, YemekAdi = "Makarna Salatası", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 290 },
                new Yemek { Id = 140, YemekAdi = "Ketçap", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 10 },
                new Yemek { Id = 141, YemekAdi = "Mayonez", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 20 },
                new Yemek { Id = 142, YemekAdi = "Hardal", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 15 },
                new Yemek { Id = 143, YemekAdi = "Barbekü Sos", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 25 },
                new Yemek { Id = 144, YemekAdi = "Ranch Sos", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 30 },
                new Yemek { Id = 145, YemekAdi = "Buffalo Sos", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 35 },
                new Yemek { Id = 146, YemekAdi = "Pesto Sos", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 40 },
                new Yemek { Id = 147, YemekAdi = "Nar Ekşisi", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 15 },
                new Yemek { Id = 148, YemekAdi = "Köri Sos", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 25 },
                new Yemek { Id = 149, YemekAdi = "Soya Sos", OlcuBirimi = OlcuBirimi.YemekKasigi, Kalori = 20 },
                new Yemek { Id = 150, YemekAdi = "Çıtır Tavuk", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 200 },
                new Yemek { Id = 151, YemekAdi = "Tavuk Burger", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 300 },
                new Yemek { Id = 152, YemekAdi = "Cheeseburger", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 350 },
                new Yemek { Id = 153, YemekAdi = "Etli Ekmek", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 280 },
                new Yemek { Id = 154, YemekAdi = "Lahmacun", OlcuBirimi = OlcuBirimi.Adet, Kalori = 200 },
                new Yemek { Id = 155, YemekAdi = "Et Döner Dürüm", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 300 },
                new Yemek { Id = 156, YemekAdi = "Kumpir", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 350 },
                new Yemek { Id = 157, YemekAdi = "Adana Dürüm", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 400 },
                new Yemek { Id = 158, YemekAdi = "Urfa Dürüm", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 450 },
                new Yemek { Id = 159, YemekAdi = "Patates Kızartması", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 250 },
                new Yemek { Id = 160, YemekAdi = "Soğan Halkası", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 300 },
                new Yemek { Id = 161, YemekAdi = "Kıymalı Pide", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 350 },
                new Yemek { Id = 162, YemekAdi = "Kaşarlı Pide", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 400 },
                new Yemek { Id = 163, YemekAdi = "Kuşbaşılı Pide", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 450 },
                new Yemek { Id = 164, YemekAdi = "Dana Eti", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 200 },
                new Yemek { Id = 165, YemekAdi = "Kuzu Eti", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 250 },
                new Yemek { Id = 166, YemekAdi = "Etli Sebzeli Pizza", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 300 },
                new Yemek { Id = 167, YemekAdi = "Kızarmış Hindi Eti", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 280 },
                new Yemek { Id = 168, YemekAdi = "Kaz Eti", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 320 },
                new Yemek { Id = 169, YemekAdi = "Keçi Eti", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 290 },
                new Yemek { Id = 170, YemekAdi = "Kurutulmuş Sığır Eti", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 350 },
                new Yemek { Id = 171, YemekAdi = "Etli Nohut", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 230 },
                new Yemek { Id = 172, YemekAdi = "Et Döner", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 300 },
                new Yemek { Id = 173, YemekAdi = "Et Kavurma", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 350 },
                new Yemek { Id = 174, YemekAdi = "Et Sote", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 320 },
                new Yemek { Id = 175, YemekAdi = "Dana Etli Burrito", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 400 },
                new Yemek { Id = 176, YemekAdi = "Etli Kuru Fasulye", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 280 },
                new Yemek { Id = 177, YemekAdi = "Domates", OlcuBirimi = OlcuBirimi.Adet, Kalori = 20 },
                new Yemek { Id = 178, YemekAdi = "Çeri Domates", OlcuBirimi = OlcuBirimi.Adet, Kalori = 15 },
                new Yemek { Id = 179, YemekAdi = "Salatalık", OlcuBirimi = OlcuBirimi.Adet, Kalori = 25 },
                new Yemek { Id = 180, YemekAdi = "Marul", OlcuBirimi = OlcuBirimi.Adet, Kalori = 10 },
                new Yemek { Id = 181, YemekAdi = "Çarliston Biber", OlcuBirimi = OlcuBirimi.Adet, Kalori = 15 },
                new Yemek { Id = 182, YemekAdi = "Kırmızı Biber", OlcuBirimi = OlcuBirimi.Adet, Kalori = 20 },
                new Yemek { Id = 183, YemekAdi = "Turp", OlcuBirimi = OlcuBirimi.Adet, Kalori = 10 },
                new Yemek { Id = 184, YemekAdi = "Ezogelin Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 180 },
                new Yemek { Id = 185, YemekAdi = "İşkembe Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 250 },
                new Yemek { Id = 186, YemekAdi = "Kırmızı Mercimek Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 200 },
                new Yemek { Id = 187, YemekAdi = "Yeşil Mercimek Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 190 },
                new Yemek { Id = 188, YemekAdi = "Sebze Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 150 },
                new Yemek { Id = 189, YemekAdi = "Tarhana Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 180 },
                new Yemek { Id = 190, YemekAdi = "Yayla Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 160 },
                new Yemek { Id = 191, YemekAdi = "Tavuk Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 140 },
                new Yemek { Id = 192, YemekAdi = "Balkabağı Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 120 },
                new Yemek { Id = 193, YemekAdi = "Mantar Çorbası", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 170 });

            modelBuilder.Entity<Kullanici>()
                .HasIndex(k => k.Email)
                .IsUnique();

            modelBuilder.Entity<Admin>()
                .HasIndex(a => a.Email)
                .IsUnique();

            modelBuilder.Entity<Admin>().HasData(new Admin { Id = 1, Email = "hasansalgin@gmail.com", Sifre = "admin123" });
            modelBuilder.Entity<Admin>().HasData(new Admin { Id = 2, Email = "ethem@gmail.com", Sifre = "bey110323." });
            modelBuilder.Entity<Admin>().HasData(new Admin { Id = 3, Email = "ozdenur@gmail.com", Sifre = "admin1234" });

        }
    }
}
