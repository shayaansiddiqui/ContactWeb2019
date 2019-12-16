using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactWeb472.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Shayaan Siddiqui - ASP.NET MVC 4 with Entity Framework";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Write To Us";

            return View();
        }
    }
}