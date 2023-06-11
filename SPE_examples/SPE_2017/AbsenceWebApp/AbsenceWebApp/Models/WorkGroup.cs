using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceWebApp.Models
{
    public class WorkGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WorkLocation { get; set; }
        public string Building { get; set; }
        public virtual List<Employee> employees { get; set; }
        public WorkGroup()
        {
            employees = new List<Employee>();
        }
    }
}