using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungFit.DAL.Enums;

namespace YoungFit.DAL.Entities
{
    public class Yemek
    {
        public int Id { get; set; }

        public string YemekAdi { get; set; } = null!;

        [Column(TypeName = "NVARCHAR(50)")]
        public OlcuBirimi OlcuBirimi { get; set; }

        public int Kalori { get; set; }

        // resimleri sağlıklı bir şekilde geçiremiyoruz.
        //public struct ResimStruct { public byte[]? Resim { get; set; } }
        public  byte[]? Resim { get; set; }


        [Column(TypeName = "NVARCHAR(20)")]
        public Ogun? YemekZamani { get; set; }
        public DateTime? Tarih { get; set; }

        public int? ToplamKalori { get; set; }



        //NP
        public List<KullaniciYemek> KullaniciYemekler { get; set; } = new List<KullaniciYemek>();

        public override string ToString()
        {
            return YemekAdi;
        }


    }
}
