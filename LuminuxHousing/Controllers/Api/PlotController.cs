using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using LuminuxHousing.Models;

namespace LuminuxHousing.Controllers.Api
{
    public class PlotController : ApiController
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

        // GET: api/Plot
        public IQueryable<Plot> GetPlots()
        {
            return _context.Plots.Include(p => p.Size);
        }

        // GET: api/Plot/5
        public IHttpActionResult GetPlot(int id)
        {
            var plot =  _context.Plots.Include(p => p.Size).SingleOrDefault(pId =>pId.Id == id);
            if (plot == null)
            {
                return NotFound();
            }

            return Ok(plot);
        }

        // PUT: api/Plot/5
        public  IHttpActionResult PutPlot(int id, Plot plot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != plot.Id)
            {
                return BadRequest();
            }

            _context.Entry(plot).State = EntityState.Modified;

            try
            {
                _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            { 
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Plot
        public  IHttpActionResult PostPlot(Plot plot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Plots.Add(plot);
            _context.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = plot.Id }, plot);
        }

        // DELETE: api/Plot/1
        [HttpDelete]
        public  IHttpActionResult DeletePlot(int id)
        {
            var plot = _context.Plots.SingleOrDefault(p => p.Id == id);
            if (plot == null)
            {
                return NotFound();
            }
            _context.Plots.Remove(plot);
            _context.SaveChanges();
            return Ok(plot);
        }

       
    }
}