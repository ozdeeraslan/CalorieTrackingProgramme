using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungFit.DAL.Enums;

namespace YoungFit.DAL.Entities
{
    public class KullaniciYemek
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public int YemekId { get; set; }
        public Yemek Yemek { get; set; }


      
        public int ToplamKalori { get; set; }
        public DateTime Tarih { get; set; }

        [Column(TypeName = "NVARCHAR(20)")]
        public Ogun OgunZamanı { get; set; }

        public override string ToString()
        {
            return $"{Yemek.YemekAdi} - {Yemek.Kalori} kalori - {Tarih.ToShortDateString()} - {OgunZamanı}";
        }
    }
}
