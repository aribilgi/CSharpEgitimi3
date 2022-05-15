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
        public ActionResult Index(string kelime) // Index sayfası veri listeleme için kullanılır
        {
            // listeleme sayfası için add view dan açılan ekrandan template olarak list i, model class product ı, db context urundbcontext i seçerek oluştururuz.
            if (!string.IsNullOrWhiteSpace(kelime)) // Eğer query stringden kelime değeri gelmişse
            {
                return View(context.Products.Where(p => p.UrunAdi.Contains(kelime)).ToList()); // context üzerindeki Products ları where ile filtrele ve ürün adlarının içinde kelime den gelen değer geçenleri listele.
            }
            return View(context.Products.ToList()); // Sayfa ön yüzüne view içerisinde parametre olarak ürün listesini göndermemiz lazım aksi taktirde foreach döngüsünde Nesne başvurusu bir nesnenin örneğine ayarlanmadı. hatası alırız!!!
        }

        // GET: Mvc15EFCRUD/Details/5
        public ActionResult Details(int id)
        {
            var urun = context.Products.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // GET: Mvc15EFCRUD/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(context.Categories.ToList(), "Id", "Name");
            return View();
        }

        // POST: Mvc15EFCRUD/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid) // Eğer model durumu(doğrulama kuralları) geçerliyse
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
                    ModelState.AddModelError("", "Hata Oluştu! Kayıt Eklenemedi!"); // Ekrana ilgili mesajı yazdırdık.
                }
            }
            ViewBag.CategoryId = new SelectList(context.Categories.ToList(), "Id", "Name"); // Post işleminden sonra hata oluşursa kategori bilgilerini tekrar dropdown liste doldurduk yoksa hata alırız!
            return View(product); // Eğer hata oluşursa gelen nesneyi ekrana geri gönder
        }

        // GET: Mvc15EFCRUD/Edit/5
        public ActionResult Edit(int id)
        {
            var urun = context.Products.Find(id); // Adres çubuğundaki route id den gelen bilgiye göre find metoduyla eşleşen ürünü ara
            if (urun == null) // Eğer gönderilen id ile eşleşen ürün bulunamadıysa
            {
                return HttpNotFound(); // Geriye HttpNotFound ile bulunamadı sayfası döndür
            }
            ViewBag.CategoryId = new SelectList(context.Categories.ToList(), "Id", "Name", urun.CategoryId); // urun.CategoryId değeri ön yüzdeki dropdown list in seçili değerini ayarlar.
            return View(urun); // eğer id ye ait ürün varsa bu ürünü view a gönder
        }

        // POST: Mvc15EFCRUD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                // TODO: Add update logic here
                context.Entry(product).State = System.Data.Entity.EntityState.Modified; // context üzerinden bize parametreyle gönderilen product ı bul ve o nesnenin durumunu güncellenecek olarak işaretle
                context.SaveChanges(); // Değişiklikleri kaydet
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.CategoryId = new SelectList(context.Categories.ToList(), "Id", "Name", product.CategoryId);
                return View(product); // Eğer güncelleme işleminde bir hata oluşursa parametreden gelen product ı sayfaya geri gönder ki ekrandaki textboxlar boşalmasın.
            }
        }

        // GET: Mvc15EFCRUD/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.Products.Find(id));
        }

        // POST: Mvc15EFCRUD/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                // TODO: Add delete logic here
                context.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
