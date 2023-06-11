using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoServiceWebApp.Models
{
    public class CarAutoService
    {
        public int CarId { get; set; }
        public List<Car> cars { get; set; }
        public int AutoServiceId { get; set; }
        public AutoService service { get; set; }
        public CarAutoService()
        {
            cars = new List<Car>();
        }
    }
}