using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_AE6.Models
{
    public class Store
    {
        public Store()
        {
            albums = new List<Album>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "The store's name is required!")]
        public string Name { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Album> albums { get; set; }
    }
}