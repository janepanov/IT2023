using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoService.Models
{
    public class AutoService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public virtual List<Car> cars { get; set; }
        public AutoService()
        {
            cars = new List<Car>();
        }
    }
}