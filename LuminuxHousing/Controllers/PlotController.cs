using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LuminuxHousing.Models;

namespace LuminuxHousing.Controllers
{
    public class PlotController : Controller
    {
        protected ApplicationDbContext _context;

        public PlotController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Plot
        public ActionResult ProjectDetails()
        {
            return View();
        }
    }
}