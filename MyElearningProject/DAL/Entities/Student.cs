using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPassword { get; set; }
        public string StudentImageUrl { get; set; }
        public List<CourseRegister> CourseRegisters { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Process> Processes { get; set; }
    }
}