using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEgitim.Models;

namespace MVCEgitim.Controllers
{
    public class Mvc09ModelBindingController : Controller
    {
        // GET: Mvc09ModelBinding
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kullanici()
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Nihat",
                Soyad = "Ağa",
                Email = "nihat@guvenlik.com",
                KullaniciAdi = "guvenlik"
            };
            return View(kullanici); // View sayfasına model sınıfı bu şekilde gönderiliyor
        }
        [HttpPost]
        public ActionResult Kullanici(Kullanici kullanici) // Model classımızı bu şekilde parametre olarak kullanabiliyoruz
        {
            ViewBag.Mesaj = "Kullanıcı Adı : " + kullanici.Ad;
            ViewData["Vdata"] = "Kullanıcı Soyadı : " + kullanici.Soyad;
            TempData["Tdata"] = "Kullanıcı Email : " + kullanici.Email;
            return View(kullanici); // View a kullanici modelini gönder
        }
        public ActionResult Adres() // Get 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adres(Adres adres) // Get 
        {
            ViewBag.Mesaj = "Şehir : " + adres.Sehir; // ön yüze şehir verisi gönderiyoruz
            ViewData["Vdata"] = "İlçe : " + adres.Ilce;// View a ilçe verisi gönderiyoruz
            TempData["Tdata"] = "Açık Adres : " + adres.AcikAdres; // tempdata 2 kez kullanılabilir diğerleri 1 kez
            return View(adres);
        }
    }
}