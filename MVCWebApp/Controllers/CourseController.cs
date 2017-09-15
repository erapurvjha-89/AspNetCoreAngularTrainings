using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class CourseController : Controller
    {
        static List<Courses> course;

        public ViewResult Create()
        {

            return View();
        }
       
        public ViewResult ListOfCourses()
        {
            //Courses crs = new Courses();
            //crs.ListOfCourse();
            return View(ListOfCourse());
        }
        [HttpPost]
        public ViewResult Create(Courses C)
        {
          course = ListOfCourse();
            course.Add(C);
            return View("ListOfCourses", course);
        }

        public  List<Courses> ListOfCourse()
        {
            List<Courses> course = new List<Courses>();
            course.Add(new Courses { CourseID = 1, CourseName = "ASP.NET", CourseDescription = "Agility training given by Nagaraju sir", CourseFees = "10000", CourseTutor = "Nagaraju sir", CreatedDate = DateTime.Now });
            course.Add(new Courses { CourseID = 2, CourseName = "MVC ", CourseDescription = "Agility training given by Nagaraju sir", CourseFees = "20000", CourseTutor = "Nagaraju sir", CreatedDate = DateTime.Now });
            course.Add(new Courses { CourseID = 3, CourseName = "MVC Core", CourseDescription = "Agility training given by Nagaraju sir", CourseFees = "15000", CourseTutor = "Nagaraju sir", CreatedDate = DateTime.Now });
            course.Add(new Courses { CourseID = 4, CourseName = "Angular 2", CourseDescription = "Agility training given by Nagaraju sir", CourseFees = "70000", CourseTutor = "Nagaraju sir", CreatedDate = DateTime.Now });
            course.Add(new Courses { CourseID = 5, CourseName = "CSS", CourseDescription = "Agility training given by Nagaraju sir", CourseFees = "20000", CourseTutor = "Nagaraju sir", CreatedDate = DateTime.Now });
            course.Add(new Courses { CourseID = 6, CourseName = "HTML5", CourseDescription = "Agility training given by Nagaraju sir", CourseFees = "10600", CourseTutor = "Nagaraju sir", CreatedDate = DateTime.Now });
            course.Add(new Courses { CourseID = 7, CourseName = "WEB API", CourseDescription = "Agility training given by Nagaraju sir", CourseFees = "10070", CourseTutor = "Nagaraju sir", CreatedDate = DateTime.Now });
            course.Add(new Courses { CourseID = 8, CourseName = "Entity FW", CourseDescription = "Agility training given by Nagaraju sir", CourseFees = "14000", CourseTutor = "Nagaraju sir", CreatedDate = DateTime.Now });
            course.Add(new Courses { CourseID = 9, CourseName = "Identity FW", CourseDescription = "Agility training given by Nagaraju sir", CourseFees = "10900", CourseTutor = "Nagaraju sir", CreatedDate = DateTime.Now });
            return course;
        }
    }
}