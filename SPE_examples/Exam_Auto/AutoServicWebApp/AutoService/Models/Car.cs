﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoService.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public float MaxSpeed { get; set; }
        public string Image { get; set; }

        public virtual List<AutoService> services { get; set; }
        public Car()
        {
            services = new List<AutoService>();
        }
    }
}