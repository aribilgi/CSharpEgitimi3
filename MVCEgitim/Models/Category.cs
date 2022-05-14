using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCEgitim.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Kategori Adı"), Required, StringLength(50)]
        public string Name { get; set; }
        // Kategori ile product arasında bire çok ilişki kurma
        public virtual ICollection<Product> Products { get; set; } // 1 kategorinin 1 den çok ürünü olabileceğini belirttik
        public Category()
        {
            Products = new List<Product>();
        }
    }
}