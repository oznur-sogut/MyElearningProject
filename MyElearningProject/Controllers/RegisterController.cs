using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class RegisterController : Controller
    {
        ELearningContext context= new ELearningContext();
        [HttpGet]
        public ActionResult RegisterIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterIndex(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("LoginIndex","Login");
        }
    }
}