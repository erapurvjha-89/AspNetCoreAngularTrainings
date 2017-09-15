using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;
using System.Dynamic;

namespace MVCWebApp.Controllers
{
    public class F2Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MTitle = "Learning";
            ViewBag.Subtitle = "aa";
            return View();
        }
        public ViewResult ListDepartments()
        {
            return View(GetDepartments());
        }
        private List<Dept> GetDepartments()
        {
            List<Dept> depts = new List<Dept>() {
            new Dept() { DeptNo=10,DName="Sales",Loc="North"},
            new Dept() { DeptNo = 11, DName = "Sales", Loc = "North" },
            new Dept() { DeptNo = 12, DName = "Sales", Loc = "North" }
            };
            return depts;


        }
        [HttpGet]
        public ViewResult AddDept()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddDept(int DeptNo, string DeptName, string Loc)
        {
            List<Dept> dept = GetDepartments();
            dept.Add(new Dept() { DeptNo = DeptNo, DName = DeptName, Loc = Loc });
            return View("ListDepartments", dept);
        }

        public List<Employee> GetEmployee()
        {
            List<Employee> emp = new List<Employee>();

            emp.Add(new Employee { EmployeeID = 1, EmpName = "Apurv", Salary = "50000" });
            emp.Add(new Employee { EmployeeID = 1, EmpName = "Koustav", Salary = "50000" });
            emp.Add(new Employee { EmployeeID = 2, EmpName = "Vivek", Salary = "50000" });

            emp.Add(new Employee { EmployeeID = 3, EmpName = "Sandeep", Salary = "50000" });
            emp.Add(new Employee { EmployeeID = 4, EmpName = "Balaji", Salary = "50000" });
            return emp;

        }
        public ViewResult ListOfEmployees()
        {
            return View(GetEmployee());
        }

        //public class ViewModel
        //{
        //    public IEnumerable<Employee> Employee { get; set; }
        //    public IEnumerable<Dept> Dept { get; set; }
        //}
        public ActionResult IndexViewModel()
        {
            //ViewBag.Message = "two models in same view";
            //ViewModel myModel = new ViewModel();
            //myModel.Employee = GetEmployee();
            //myModel.Dept = GetDepartments();
            //return View(myModel);
            //Organization org = new Organization();
            //org.dep = GetDepartments();
            //org.emp = GetEmployee();
            //return View(org);

            dynamic myModel = new ExpandoObject();
            myModel.dept = GetDepartments();
            myModel.Empl = GetEmployee();
            return View(myModel);
        }

    }
}