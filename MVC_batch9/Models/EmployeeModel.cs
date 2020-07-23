using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_batch9.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }

    }

    public class empdept {
        public EmployeeModel emp { get; set; }

        public Department dept { get; set; }
    }
}