using MVC_AE3_EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_AE3_EF.Models
{
    public class Client
    {
        public Client()
        {
            movies = new List<Movie>();
        }

        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "The client's name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The client's address is required!")]
        public string Address { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Age must be a postiive number > 0")]
        public int Age { get; set; }

        public string MembershipCard { get; set; }

        public string Telephone { get; set; }

        public bool IsSubscribed { get; set; }

        public virtual ICollection<Movie> movies { get; set; }
    }
}