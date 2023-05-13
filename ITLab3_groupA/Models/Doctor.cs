using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITLab3_groupA.Models
{
    public class Doctor
    {
        public Doctor()
        {
            patients = new List<Patient>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "The doctor's name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The doctor's surname is required!")]
        public string Surname { get; set; }

        public string Specialty { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "The doctor's phone is required!")]
        public string Phone { get; set; }

        public int HospitalId { get; set; }

        public Hospital hospital { get; set; }

        public virtual ICollection<Patient> patients { get; set; }
    }
}