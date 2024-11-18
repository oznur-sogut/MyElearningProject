using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string TestimonialNameSurname { get; set; }
        public string TestimonialTitle { get; set; }
        public string TestimonialImageUrl { get; set; }
        public string TestimonialComment { get; set; }
        public bool TestimonialStatus { get; set; }
    }
}