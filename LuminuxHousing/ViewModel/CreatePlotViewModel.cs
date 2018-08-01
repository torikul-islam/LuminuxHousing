using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LuminuxHousing.Models;

namespace LuminuxHousing.ViewModel
{
    public class CreatePlotViewModel
    {
        public IEnumerable<Size> Sizes { get; set; }
        public Plot Plot { get; set; }
    }
}