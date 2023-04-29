using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITLab2_groupA.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The event's name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The event's location is required!")]
        // Updated model for group B
        [StringLength(30, MinimumLength = 5)]
        public string Location { get; set; }

        public static List<EventModel> Events { get; set; } = new List<EventModel>();
    }
}