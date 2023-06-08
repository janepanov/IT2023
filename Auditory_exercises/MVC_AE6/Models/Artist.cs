using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_AE6.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "The artist's name is required!")]
        public string Name { get; set; }
    }
}