using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCEgitim
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", // url yapısı tarayıcı adres çubuğu üzerinden uygulamamıza yapılan isteği kontrol eder. controller a adres çubuğundaki ilk / a kadar yazılan isim yerleştirilir. /{action} kısmı ise bu controllerdaki hangi action ın çalıştırılacağını belirler. /{id} ise bu sayfada id ile bir filtreleme yapılmak istenirse kullanılır ve id zorunlu değildir.
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional } // defaults kısmı eğer uygulamaya adres çubuğundan controller ve action adı gelmezse varsayılan olarak hangi controller ve action un çalıştırılacağını belirler
            );
        }
    }
}
