using MVC_AE3_EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_AE3_EF.Models
{
    public class Movie
    {
        public Movie()
        {
            clients = new List<Client>();
        }

        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "The movie's name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The movie's rating is required!")]
        public float Rating { get; set; }

        [Display(Name = "Download URL")]
        public string DownloadURL { get; set; }

        [Display(Name = "The image URL")]
        public string ImageURL { get; set; }

        public virtual ICollection<Client> clients { get; set; }
    }
}