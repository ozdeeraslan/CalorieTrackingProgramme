using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungFit.BL.Interfaces;
using YoungFit.DAL.Context;


namespace YoungFit.BL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private static readonly UygulamaDbContext _db = new UygulamaDbContext();
        private DbSet<T> varliklar;
        public Repository()
        {
            varliklar = _db.Set<T>();
        }

        public void Ekle(T eklenecekOge)
        {
            _db.ChangeTracker.Clear();
            varliklar.Add(eklenecekOge);
            _db.SaveChanges();
        }

        public void Guncelle()
        {
            _db.SaveChanges();
        }

        public void Sil(T silinecekOge)
        {
            _db.ChangeTracker.Clear();
            varliklar.Remove(silinecekOge);
            _db.SaveChanges();
        }
        public T IdYeGoreGetir(int Id)
        {
            return varliklar.Find(Id);
        }

        public List<T> HepsiniGetir()
        {
            return varliklar.ToList();
        }
    }
}
