using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LuminuxHousing.Models;
using LuminuxHousing.ViewModel;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http.Results;
using System.Web.Services;
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

        [Authorize(Roles = RoleName.Admin)]
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
        [Authorize(Roles = RoleName.Admin)]
        public async Task<ActionResult> Create(Plot plot)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CreatePlotViewModel
                {
                    Plot = plot,
                    Sizes = _context.Sizes.ToList()
                };
                return View("Create", viewModel);
            }
            
             _context.Plots.Add(plot);
            await _context.SaveChangesAsync();
            return RedirectToAction("ProjectDetails", "Plot");
        }

        
        public ActionResult ProjectDetails(Plot plot)
        {
            var plots = _context.Plots.Include(c => c.Size).ToList();
            if (User.IsInRole(RoleName.Admin))
            {
                return View("ProjectDetails");
            }
            
            return View("UserProjectDetails");
        }

        [Authorize(Roles = RoleName.Admin)]
        public ActionResult PlotDetails(int? id, Plot plot)
        {
            var plots = _context.Plots.Include(s =>s.Size).SingleOrDefault(c => c.Id == id);
            if (plots == null)
                throw new Exception("404.html");
            

            if (ModelState.IsValid && !plots.Id.Equals(null))
            {

                plots.Name = plot.Name;
                plots.SizeId = plot.SizeId;
                plots.Price = plot.Price;
                plots.StartDate = plot.StartDate;
                plots.Note = plot.Note;
                plots.Sold = plot.Sold;
                plots.OwnerName = plot.OwnerName;
                plots.OwnerPhone = plot.OwnerPhone;
            }
            else
            {
                var viewModelDetails = new CreatePlotViewModel
                {
                    Plot = plots,
                    Sizes = _context.Sizes.ToList()
                };
                return View("PlotDetails", viewModelDetails);
            }

            _context.SaveChanges();
            return RedirectToAction("ProjectDetails", "Plot");
        }

       
    }
}