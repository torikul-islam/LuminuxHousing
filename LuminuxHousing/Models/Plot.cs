using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace LuminuxHousing.Models
{
    public class Plot
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public Size Size { get; set; }

        [DisplayName("Plot Size")]
        [Required]
        public int SizeId { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [DisplayName("Construction Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        public string Note { get; set; }

        [Required]
        public bool Sold { get; set; }

        [Required]
        [DisplayName("Owner Name")]
        public string OwnerName { get; set; }

        [Required]
        [RegularExpression(@"\+?(88)?0?1[56789][0-9]{8}", ErrorMessage = "Invalid Phone No.")]
        [DisplayName("Phone No.")]
        public string OwnerPhone { get; set; }
    }
}