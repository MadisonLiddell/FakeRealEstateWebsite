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

        public ActionResult AllAgents()
        {
            return View("Agents", dbContext.agents.ToList());
        }

        public ActionResult Agents(string searchText)
        {
            if (searchText == null)
            {
                return View();
            }
            else
            {
                return View(dbContext.agents.Where(x => x.agent_fname.StartsWith(searchText) || x.agent_lname.StartsWith(searchText) || x.agent_city.StartsWith(searchText) || x.agent_state.StartsWith(searchText)).ToList());
            } 
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
