using System.Data.Entity;

namespace MVCEgitim.Models
{
    public class UrunDbContext : DbContext //  DbContext Entity framework den geliyor, veritabanı işlemleri yapmamızı sağlıyor.
    {
        public DbSet<Product> Products { get; set; } // Veritabanındaki Products tablosunu temsil eden dbset
    }
}