﻿using System;
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
            some = some + "more";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            string d = "343";
            return View();
        }
    }
}