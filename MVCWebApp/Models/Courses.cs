using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp.Models
{
    public class Courses
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }

        public string CourseImageURL { get; set; }
        public string CourseVideoURL { get; set; }
        public string  CourseTutor  { get; set; }
        public string CourseFees { get; set; }
        public DateTime CreatedDate { get; set; }

      

    }
}
