using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITLab3_groupA.Models
{
    public class Hospital
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The hospital's name is required!")]
        [Display(Name = "Hospital's name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The hospital's address is required!")]
        [Display(Name = "Hospital's address")]
        public string Address { get; set; }

        public string Phone { get; set; }

        public string Image { get; set; }
    }
}