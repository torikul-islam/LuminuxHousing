using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuminuxHousing.DTOs
{
    public class PlotDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SizeId { get; set; }
        public int Price { get; set; }

        public DateTime StartDate { get; set; }

        public string Note { get; set; }

        public bool Sold { get; set; }

        public string OwnerName { get; set; }

        public string OwnerPhone { get; set; }
    }
}