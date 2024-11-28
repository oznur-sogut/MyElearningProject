using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
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
        [HttpGet]
        public ActionResult AddCourse()
        {
            List<SelectListItem> categories= (from x in context.Categories.ToList()
                                              select new SelectListItem
                                              {
                                                  Text=x.CategoryName,
                                                  Value=x.CategoryID.ToString()
                                              }).ToList();
            ViewBag.v=categories;
            List<SelectListItem> instructors = (from y in context.Instructors.ToList().OrderBy(z=>z.InstructorName)
                                                select new SelectListItem
                                                {

                                                    Text = y.InstructorName+ " "+y.InstructorSurname,
                                                    Value = y.InstructorID.ToString()
                                                }).ToList();
            ViewBag.v2=instructors;
            return View();
        }
        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return RedirectToAction("CourseIndex");
        }
        public ActionResult DeleteCourse(int id)
        {
            var value = context.Courses.Find(id);
            context.Courses.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CourseIndex");
        }
        public ActionResult UpdateCourse(int id)
        {
            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.v = categories;
            List<SelectListItem> instructors = (from y in context.Instructors.ToList().OrderBy(z => z.InstructorName)
                                                select new SelectListItem
                                                {

                                                    Text = y.InstructorName + " " + y.InstructorSurname,
                                                    Value = y.InstructorID.ToString()
                                                }).ToList();
            ViewBag.v2 = instructors;
            var value=context.Courses.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCourse(Course course)
        {
            var value = context.Courses.Find(course.CourseID);
            value.CourseTitle= course.CourseTitle;
            value.CourseDuration= course.CourseDuration;
            value.CoursePrice= course.CoursePrice;
            value.CourseImageUrl= course.CourseImageUrl;
            value.InstructorID= course.InstructorID;
            value.CategoryID= course.CategoryID;
            context.SaveChanges();
            return RedirectToAction("CourseIndex");
        }
    }
}