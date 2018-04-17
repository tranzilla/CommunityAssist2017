using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityAssist2017.Models;//reference to the models used 

namespace CommunityAssist2017.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //initialized entities - making communityassist2017 database to a class to allow tables to be pass through
            CommunityAssist2017Entities db = new CommunityAssist2017Entities();
            //pass the collection GrantType to the index as a list
            return View(db.GrantTypes.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}