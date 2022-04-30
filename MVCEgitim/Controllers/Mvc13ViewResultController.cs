using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc13ViewResultController : Controller
    {
        // GET: Mvc13ViewResult
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return Redirect("/Home/Index"); // 1. örnek anasayfaya yönlendirme
            
        }
    }
}