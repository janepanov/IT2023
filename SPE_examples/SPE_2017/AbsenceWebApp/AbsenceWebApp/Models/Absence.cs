using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceWebApp.Models
{
    public class Absence
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int EmployeeId { get; set; }
        public bool isApproved { get; set; } = false;
        public Employee employee { get; set; }
    }
}