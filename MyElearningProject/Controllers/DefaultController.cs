using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class DefaultController : Controller
    {
       ELearningContext context= new ELearningContext();
        public ActionResult PageIndex()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialCarousel()
        {
            var value= context.Carousels.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialCard()
        {
            var value = context.Abouts.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialAbout()
        {
            var value = context.Abouts.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialCategories()
        {
            ViewBag.categoryCount= context.Categories.Select(x=>x.CategoryID).Count();
            var value = context.Categories.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialCourses()
        {
            ViewBag.studentCount=context.Courses.Select(x=>x.CourseID).Count();
            var value=context.Courses.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialInstructor()
        {
            var value=context.Instructors.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialStudent()
        {
            var value=context.Students.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}