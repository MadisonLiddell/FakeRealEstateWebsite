using FakeRealEstateWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FakeRealEstateWebsite.Controllers
{
    public class SearchController : Controller
    {
        private Model1 dbContext = new Model1();
        //
        // GET: /Search/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agents()
        {
            return View(dbContext.agents.ToList());
        }

        public ActionResult Properties()
        {
            return View(dbContext.properties.ToList());
        }
        public ActionResult Custom() //TODO
        {
            return View();
        }
    }
}
