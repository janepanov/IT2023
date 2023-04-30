using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_AE2.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "The movie's name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The movie's rating is required!")]
        public float Rating { get; set; }

        [Display(Name = "Download URL")]
        public string DownloadURL { get; set; }

        [Display(Name = "The image URL")]
        public string ImageURL { get; set; }
    }
}