using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoServiceWebApp.Models
{
    public class AutoService
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Име")]
        public string Name { get; set; }
        [Required]
        [Range(1,30)]
        public int Capacity { get; set; }
        public virtual List<Car> cars { get; set; }
        public AutoService()
        {
            cars = new List<Car>();
        }
    }
}