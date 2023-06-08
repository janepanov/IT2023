using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_AE6.Models
{
    public class Genre
    {
        public Genre()
        {
            albums = new List<Album>();
        }

        public int GenreId { get; set; }

        [Required(ErrorMessage = "The genre's name is required!")]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Album> albums { get; set; }
    }
}