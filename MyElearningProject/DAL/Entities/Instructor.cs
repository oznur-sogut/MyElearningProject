using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
        [StringLength(30)]
        public string InstructorSurname { get; set; }
        public string InstructorImageUrl { get; set; }
        public List<Course> Courses { get; set; }
        public string InstructorTitle { get; set; }
        public string InstructorCoverImage { get; set; }
    }
}