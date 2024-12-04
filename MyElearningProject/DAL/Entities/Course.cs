using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseTitle { get; set; }
        public decimal CoursePrice { get; set; }
        public int CourseDuration { get; set; }
        public string CourseImageUrl { get; set; }
        public int CategoryID { get; set; }
        public int InstructorID { get; set; }
        public virtual Category Category { get; set; }
        public virtual Instructor Instructor { get; set; }
        public List<CourseRegister> CourseRegisters { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Process> Processes { get; set; }
    }
}