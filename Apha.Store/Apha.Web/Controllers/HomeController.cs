using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apha.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string some = "some var added";
            some = some + "more reset..one more reset";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            string newvar = "change1";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            string d = "343";
            int change2 = 566;
            return View();
        }
    }
}