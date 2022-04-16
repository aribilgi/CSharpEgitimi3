using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc01RazorSyntaxController : Controller
    {
        // Mvc de kendi controller ımızı oluşturmak için Controllers klasörüne sağ tıklayıp add menüsünden Controller a basıyoruz. Açılan pencerede empty i seçip ok ile devam ediyoruz. Açılan pencerede sonu controller ile biten dosyaya bir isim verip ok diyoruz.

        // Controller oluşturduğumuzda Mvc01RazorSyntax yani controller ile aynı isimde Views klasöründe bir klasör oluşur.

        // GET: Mvc01RazorSyntax
        public ActionResult Index() // Mvc de View sayfası otomatik oluşmaz! Bizim oluşturmamız gerekir. Bir view oluşturmak için Action adına(Index) sağ  tıklayıp add view diyerek açılan pencereden ayarlarını belirleyip view oluştururuz.
        {
            return View();
        }
    }
}