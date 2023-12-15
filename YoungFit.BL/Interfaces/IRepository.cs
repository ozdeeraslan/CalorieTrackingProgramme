using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungFit.BL.Interfaces
{
    public interface IRepository<T>
    {
        public void Ekle(T eklenecekOge);
        public void Guncelle();

        public void Sil(T silinecekOge);

        public T IdYeGoreGetir(int Id);
        public List<T> HepsiniGetir();

    }
}
