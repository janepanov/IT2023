using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceWebApp.Models
{
    public class WorkGroupEmployee
    {
        public int WorkGroupId { get; set; }
        public List<WorkGroup> workGroups { get; set; }
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
        public WorkGroupEmployee()
        {
            workGroups = new List<WorkGroup>();
        }
    }
}