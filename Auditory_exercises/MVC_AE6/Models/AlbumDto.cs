using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_AE6.Models
{
    public class AlbumDto
    {
        public int Id { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }

        [Required(ErrorMessage = "The album's title is required!")]
        public string Title { get; set; }

        public decimal Price { get; set; }

        public string AlbumCover { get; set; }

        public Genre genre { get; set; }

        public Artist artist { get; set; }

        public string Name { get; set; }
    }
}