using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp.Models
{
    public class Dept
    {

        public int DeptNo { get; set; }
        public string DName { get; set; }
        public string Loc { get; set; }
    }

    public class  Employee
    {

        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string Salary { get; set; }
    }

    public class Organization
    {
        public List<Dept> dep = new List<Dept>();
        public List<Employee> emp = new List<Employee>();

    }
}
