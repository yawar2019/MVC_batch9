using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBasedFirstApproach.Models
{
    public class EmployeeDepartment
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> EmpSalary { get; set; }
        public Nullable<int> DeptId { get; set; }
        public string DeptName { get; set; }
    }    
}