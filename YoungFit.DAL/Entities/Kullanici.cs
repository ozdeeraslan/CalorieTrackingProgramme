using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungFit.DAL.Entities
{
    public class Kullanici 
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Sifre { get; set; } = null!;

        public List<KullaniciYemek> KullaniciYemekler { get; set; } = new List<KullaniciYemek>();

        public override string ToString()
        {
            return Email;
        }
    }
}
