using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc11SessionCookieController : Controller
    {
        // GET: Mvc11SessionCookie : Web uygulamalarında oturum işlemleri için session ve cookie den yararlanırız
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text)
        {
            // Session oluşturup değer atama..
            Session["deger"] = text; // 1. yöntem
            Session.Add("seysin", "seysin : " + text); // 2. yöntem
            return View();
        }
        public ActionResult Sessions()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sessions(string text)
        {
            if (Session["deger"] != null) // eğer session boş değilse
            {
                Session.Remove("deger"); // deger ismindeki sessionu sil
            }
            return View();
        }
        [HttpPost]
        public ActionResult CookieOlustur(string kuki)
        {
            HttpCookie cookieKullanici = new HttpCookie("kullanici", kuki)
            {
                Expires = DateTime.Now.AddMinutes(10) // Kukinin yaşam süresi
            }; //Cookie oluşturma
            HttpContext.Response.Cookies.Add(cookieKullanici); //Cookie yi istemciye yerleştirme
            return RedirectToAction("CookieOku"); // sayfayı CookieOku sayfasına yönlendirme
        }
        
        public ActionResult CookieOku()
        {
            if (HttpContext.Request.Cookies["kullanici"] == null) // Cookie yi kontrol et
                ViewBag.Kullanici = "Cookie Yok"; // Eğer kuki yoksa
            else // Cookie boş değilse
                ViewBag.Kullanici = "Cookie Değeri : " + HttpContext.Request.Cookies["kullanici"].Value; //Cookie nin değerini okuyup ViewBag e atadık
            return View();
        }

        [HttpPost]
        public ActionResult CookieSil()
        {
            if (HttpContext.Request.Cookies["kullanici"] != null)
                HttpContext.Response.Cookies["kullanici"].Expires = DateTime.Now.AddSeconds(-3);
            else ViewBag.Message = "Cookie Yok";

            return RedirectToAction("CookieOku");
        }
    }
}