using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc08ViewToControllerController : Controller
    {
        // GET: Mvc08ViewToController
        public ActionResult Index(string txtAra)// Mvc de ındex metodu içerisine bu şekilde parametre ekleyerek ön yüzden gönderilen veriyi yakalayabiliyoruz. Dikkat! eşleşme sağlanabilmesi için ön yüzdeki elemanın name bilgisi ile buradaki değişken bilgisinin aynı isimde olması lazım yoksa eşleşmez!!!
        {
            ViewBag.GetVerisi = "Aranan kelime : " + txtAra;
            // Get metodu ile veri gönderimi yaparsak gönderdiğimiz veriler adres çubuğundan query string yöntemiyle iletilir!
            return View();
        }
    }
}