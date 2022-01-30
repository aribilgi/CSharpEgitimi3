using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    public class KategoriDAL
    {
        public List<Kategori> GetAll()
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                return context.Kategoriler.ToList();
            }
        }
        public int Add(Kategori kategori)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(kategori);
                urun.State = EntityState.Added;
                return context.SaveChanges(); //değişiklikleri kaydet
            }
        }
        public int Update(Kategori kategori)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(kategori);
                urun.State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        public int Delete(Kategori kategori)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(kategori);
                urun.State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }
    }
}
