using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungFit.BL.Interfaces
{
    public interface IGirisSekli
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
    }
}
