using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_AE1.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string DownloadURL { get; set; }

        public string ImageURL { get; set; }

        public float Rating { get; set; }
    }
}