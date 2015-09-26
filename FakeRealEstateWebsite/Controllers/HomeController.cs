using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FakeRealEstateWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the RealFake Estates website.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This website uses a completely made up real estate database. It was created purely for learning.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact the developer.";

            return View();
        }
    }
}
