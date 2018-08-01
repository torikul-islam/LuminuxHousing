using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LuminuxHousing.Models;
using LuminuxHousing.ViewModel;
using System.Data.Entity;
using System.Web.UI.WebControls;


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


        public ActionResult Create()
        {
            var sizes = _context.Sizes.ToList();
            var viewModel = new CreatePlotViewModel
            {
                Sizes = sizes
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Plot plot)
        {
            if (plot.Id.Equals(0))
                _context.Plots.Add(plot);
            else
            {
                var plotsInDb = _context.Plots.Single(p => p.Id == plot.Id);

                plotsInDb.Name = plot.Name;
                plotsInDb.SizeId = plot.Size.Id;
                plotsInDb.Price = plot.Price;
                plotsInDb.StartDate = plot.StartDate;
                plotsInDb.Note = plot.Note;
                plotsInDb.Sold = plot.Sold;
                plotsInDb.OwnerName = plot.OwnerName;
                plotsInDb.OwnerPhone = plot.OwnerPhone;

            }
            _context.SaveChanges();
            return RedirectToAction("ProjectDetails", "Plot");
        }

        public ActionResult ProjectDetails()
        {
            var plots = _context.Plots.Include(c => c.Size).ToList();
            return View(plots);
        }

        public ActionResult PlotDetails(int? id)
        {
            var plots = _context.Plots.Include(s =>s.Size).SingleOrDefault(c => c.Id == id);
            if (plots == null)
                return HttpNotFound();

            var viewModel = new CreatePlotViewModel
            {
                Plot = plots,
                Sizes = _context.Sizes.ToList()
            };
            return View(viewModel);
        }
    }
}