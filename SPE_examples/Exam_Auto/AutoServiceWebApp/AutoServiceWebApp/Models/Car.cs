using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoServiceWebApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public string ImageUrl { get; set; }
        public virtual List<AutoService> services { get; set; }
        public Car()
        {
            services = new List<AutoService>();
        }
    }
}