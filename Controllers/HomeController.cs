﻿using DiValVending.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiValVending.Controllers
{
    public class HomeController : Controller
    {
        DiValVendingDb _db = new DiValVendingDb();

        public ActionResult Index()
        {
            var model = _db.Roles.ToList();

            return View(model);
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