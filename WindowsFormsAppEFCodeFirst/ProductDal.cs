using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (UrunDbContext context = new UrunDbContext())//entity framework üzerinden db işlemlerini yapabilmek için
            {
                return context.Products.ToList();//GetAll metodunun çağrıldığı yere ürün listesini döndür
            }
        }
        public int Add(Product product)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(product); //urun nesnesi oluştur ve context deki product a abone ol 
                urun.State = EntityState.Added; // urun nesnesinin durumunu added ile eklenecek olarak değiştir
                return context.SaveChanges(); //değişiklikleri kaydet
            }
        }
        public int Update(Product product)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(product); //urun nesnesi oluştur ve context deki product a abone ol 
                urun.State = EntityState.Modified; // urun nesnesinin durumunu Modified ile güncellenecek olarak değiştir
                return context.SaveChanges(); //değişiklikleri kaydet
            }
        }
        public int Delete(Product product)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(product);
                urun.State = EntityState.Deleted; 
                return context.SaveChanges();
            }
        }
    }
}
