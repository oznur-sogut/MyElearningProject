using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class StudentController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult StudentIndex()
        {
            var value = context.Students.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("StudentIndex");
        }
        public ActionResult DeleteStudent(int id)
        {
            var value = context.Students.Find(id);
            context.Students.Remove(value);
            context.SaveChanges();
            return RedirectToAction("StudentIndex");
        }
        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            var value=context.Students.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        {
            var value = context.Students.Find(student.StudentID);
            value.StudentName = student.StudentName;
            value.StudentSurname= student.StudentSurname;
            value.StudentEmail = student.StudentEmail;
            value.StudentPassword = student.StudentPassword;
            context.SaveChanges();
            return RedirectToAction("StudentIndex");
        }
    }
}