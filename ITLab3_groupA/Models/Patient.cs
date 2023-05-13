using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITLab3_groupA.Models
{
    public class Patient
    {
        public Patient()
        {
            doctors = new List<Doctor>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "The patient's code is required!")]
        [RegularExpression(@"^[0-9]{5}$", ErrorMessage = "The patient's code must be 5 digits!")]
        [Display(Name = "Patient's code")]
        public int PatientCode { get; set; }

        [Required(ErrorMessage ="The patient's name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The patient's surname is required!")]
        public string Surname { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "The patient's phone is required!")]
        public string Phone { get; set; }

        public virtual ICollection<Doctor> doctors { get; set; }
    }
}