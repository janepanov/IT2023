using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_AE2.Models
{
    public class MovieRentals
    {
        public Movie movie { get; set; }

        public List <Client> customers { get; set; } = new List<Client>();
    }
}