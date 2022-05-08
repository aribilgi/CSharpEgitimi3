using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
// Mvc de Crud işlemleri yapmak için öncelikle Nuget dan EF 6.4.4 paketini yüklüyoruz
// Veritabanı bağlantısı için diğer projenin config dosyasından Connection String kodunu kopyalayıp bu projenin web.config dosyasına ekledik.
    public class Mvc15EFCRUDController : Controller
    {
        UrunDbContext context = new UrunDbContext();
        // GET: Mvc15EFCRUD
        public ActionResult Index() // Index sayfası veri listeleme için kullanılır
        {
        // listeleme sayfası için add view dan açılan ekrandan template olarak list i, model class product ı, db context urundbcontext i seçerek oluştururuz.
            return View(context.Products.ToList()); // Sayfa ön yüzüne view içerisinde parametre olarak ürün listesini göndermemiz lazım aksi taktirde foreach döngüsünde Nesne başvurusu bir nesnenin örneğine ayarlanmadı. hatası alırız!!!
        }

        // GET: Mvc15EFCRUD/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mvc15EFCRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mvc15EFCRUD/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                context.Products.Add(product);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(product); // Eğer hata oluşursa gelen nesneyi ekrana geri gönder
            }
        }

        // GET: Mvc15EFCRUD/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mvc15EFCRUD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mvc15EFCRUD/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mvc15EFCRUD/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
