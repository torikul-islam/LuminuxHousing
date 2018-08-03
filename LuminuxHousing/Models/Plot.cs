using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuminuxHousing.Models
{
    public class Plot
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public Size Size { get; set; }

        [DisplayName("Plot Size")]
        public int SizeId { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public string Note { get; set; }

        [Required]
        public bool Sold { get; set; }

        [Required]
        public string OwnerName { get; set; }

        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string OwnerPhone { get; set; }
    }
}