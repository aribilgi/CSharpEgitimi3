using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    public class UrunDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //DbSet ler Entity framework de veritabanı tablolarını simgeler
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
    }
}
