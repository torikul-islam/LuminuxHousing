﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuminuxHousing.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            
            return View();
        }

        
        public ActionResult About()
        {
            ViewBag.Message = "About Us";
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}