using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc10ModelValidationController : Controller
    {
        // GET: Mvc10ModelValidation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniUye()
        {
            return View();
        }
        [HttpPost] // Aşağıdaki metodun post işleminde çalışacağını belirtir
        public ActionResult YeniUye(Uye uye) // YeniUye.cshtml sayfasından gönderilen veriler uye class ı ile model binding yöntemiyle bu şekilde parametreyle elde edilebiliyor
        {
            if (ModelState.IsValid) // Bu kod ile uye nesnesinde geçerlilik kuralları kontrol edilir
            {
                // Eğer uye nesnesinde geçersiz alanlar yoksa buradaki kodlar çalıştırılır
                ViewBag.UyeBilgi = $"Üye Adı : {uye.Ad} <hr /> Üye Soyad : {uye.Soyad} <hr /> Üye Mail : {uye.Email} <hr /> Üye Tc No : {uye.TcKimlikNo}"; // Eğer bilgiler geçerliyse ViewBag.UyeBilgi ile sayfa ön yüzüne verileri gönderiyoruz
            }
            return View(uye); // Eğer parametreyle gelen uye nesnesinde validasyon sorunları varsa return View(uye); koduyla ön yüz sayfasına nesneyi geri gönderiyoruz
        }
        public ActionResult UyeDuzenle(int? id) // id parametresini bu şekilde yakalayabiliriz
        {
            // Mvc de kayıt düzenleme metodunda adres çubuğundan id ye gelen değere göre ilgili kayıt veritabanında sorgulanır ve kayıt varsa sayfaya gönderilir. Kayıt yoksa hata mesajı gönderilir kayıt bulunamadı gibi
            Uye uye = new Uye()
            {
                Id = 18,
                Ad = "Fatih",
                Soyad = "Sultan",
                Email = "fatih@sultan.net",
                TcKimlikNo = "0001453"
            };
            return View(uye); // Bulunan kayıt view a gönderilir
        }
        [HttpPost]
        public ActionResult UyeDuzenle(Uye uye)
        {
            if (ModelState.IsValid)
            {
                // Projede bu alan gelen nesnenin veritabanında güncelleneceği alandır
                ViewBag.UyeBilgi = $"Üye Adı : {uye.Ad} <hr /> Üye Soyad : {uye.Soyad} <hr /> Üye Mail : {uye.Email} <hr /> Üye Tc No : {uye.TcKimlikNo}";
            }
            return View(uye);
        }
    }
}