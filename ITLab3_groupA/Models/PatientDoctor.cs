using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITLab3_groupA.Models
{
    public class PatientDoctor
    {
        public PatientDoctor()
        {
            patients = new List<Patient>();
        }

        public int DoctorId { get; set; }

        public Doctor doctor { get; set; }

        public int PatientId { get; set; }

        public ICollection<Patient> patients { get; set; }
    }
}