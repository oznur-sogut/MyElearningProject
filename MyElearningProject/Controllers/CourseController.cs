using MyElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class CourseController : Controller
    {
        ELearningContext context= new ELearningContext();
        public ActionResult CourseIndex()
        {
            var value = context.Courses.ToList();
            return View(value);
        }
    }
}