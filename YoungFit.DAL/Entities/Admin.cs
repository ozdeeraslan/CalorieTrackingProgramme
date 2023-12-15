using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungFit.DAL.Entities
{
    public class Admin 
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Sifre { get; set; } = null!;
    }
}
