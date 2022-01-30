using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsAppEFCodeFirst.Entities
{
    [Table("Kategoriler")] //Burası aşağıdaki class ın veritabanındaki hangi tablo ile ilişkilendirileceğini belirler
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public bool Durum { get; set; }
        //Kategori açıklaması
        //Eklenme Tarihi
    }
}
