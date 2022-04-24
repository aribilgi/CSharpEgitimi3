using System;
using System.ComponentModel; // Model validation için kütüphane
using System.ComponentModel.DataAnnotations;

namespace MVCEgitim.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Ad Alanını Doldurunuz!")] // Alttaki ad alanının zorunlu-boş geçilemez olmasını sağlar
        public string Ad { get; set; }
        [Required] // Required aynı zamanda veritabanında da ilgili alanı boş geçilemez yapar
        public string Soyad { get; set; }
        [Required] // Attribute leri Entity framework de kullanır
        [EmailAddress] // Alttaki alana email adresi girilmesini sağlar
        public string Email { get; set; }
        public string Telefon { get; set; }
        [DisplayName("Tc Kimlik Numarası")]
        [MinLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakterden az olamaz!")]
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakterden fazla olamaz!")]
        public string TcKimlikNo { get; set; }
        [DisplayName("Doğum Tarihi"), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}"), DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; } // datetime tipi varsayılan olarak boş geçilemez
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [DisplayName("Şifre")]
        [DataType(DataType.Password)] // Aşağıdaki alanı açık yazma yerine *** şeklinde veri girişi yaptırır
        [StringLength(10, ErrorMessage = "{0} {2} karaktarden uzun olmalı.", MinimumLength = 5)]
        public string Sifre { get; set; } // StringLength özelliği veritabanındaki uzunluğu da belirler
        [DisplayName("Şifre Tekrar"), DataType(DataType.Password)]
        [Compare("Sifre")] // SifreTekrar alanını Sifre alanı ile karşılaştır
        public string SifreTekrar { get; set; }
    }
}