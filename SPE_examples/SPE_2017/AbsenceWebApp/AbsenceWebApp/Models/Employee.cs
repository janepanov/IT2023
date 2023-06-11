using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbsenceWebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        [Required]
        [Range(1, 99)]
        public int Age { get; set; }
        public virtual List<WorkGroup> workgroups { get; set; }
        public List<Absence> absences { get; set; }
        public Employee()
        {
            workgroups = new List<WorkGroup>();
            absences = new List<Absence>();
        }
    }
}