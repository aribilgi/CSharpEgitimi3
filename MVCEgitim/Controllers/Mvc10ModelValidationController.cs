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
        public ActionResult UyeListesi()
        {
            // Burada veritabanından üye listesi çekilir ve sayfaya gönderilir
            var uyelistesi = new List<Uye>() {
                new Uye(){ Id = 18, Ad = "Fatih", Soyad = "Sultan", Email = "fatih@sultan.net", TcKimlikNo = "0000000001453" },
                new Uye(){ Id = 25, Ad = "Murat", Soyad = "Yılmaz", Email = "murat@yilmaz.co", TcKimlikNo = "0000012345432" },
                new Uye(){ Id = 34, Ad = "Hamza", Soyad = "Kabulantok", Email = "hamza@kabul.net", TcKimlikNo = "000001253456" }
            };
            return View(uyelistesi);
        }
        public ActionResult UyeSil()
        {
            Uye uye = new Uye()
            {
                Id = 18,
                Ad = "Fatih",
                Soyad = "Sultan",
                Email = "fatih@sultan.net",
                TcKimlikNo = "0001453"
            };
            return View(uye); // Ekrana verilerin gelmesi için
        }
        [HttpPost]
        public ActionResult UyeSil(int? id)
        {
            // Burada kayıt silme kodları yazılır
            TempData["mesaj"] = "<div class='alert alert-danger'><h3>Kayıt Silindi!</h3></div>";
            return View();
        }
    }
}