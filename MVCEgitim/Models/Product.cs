using System.ComponentModel.DataAnnotations;

namespace MVCEgitim.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Ürün Adı"), Required, StringLength(50)]
        public string UrunAdi { get; set; }
        [Display(Name = "Ürün Fiyatı"), Required]
        public decimal UrunFiyati { get; set; }
        [Display(Name = "Stok Miktarı"), Required]
        public int StokMiktari { get; set; }
        [Display(Name = "Ürün Kategorisi"), Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } // 1 ürünün 1 kategoriye ait olmasını sağlayarak aradaki ilişkiyi kurduk
    }
}