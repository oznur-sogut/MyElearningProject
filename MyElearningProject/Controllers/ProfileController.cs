using MyElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class ProfileController : Controller
    {
        ELearningContext context= new ELearningContext();
        [Authorize]
        public ActionResult ProfileIndex()
        {
            var values = Session["CurrentMail"];
            ViewBag.mail = Session["CurrentMail"];
            ViewBag.name = context.Students.Where(x=>x.StudentEmail== values.ToString()).Select(y=>y.StudentName+" "+y.StudentSurname).FirstOrDefault();
            return View();
        }
        public ActionResult MyCourseList()
        {
            string values = Session["CurrentMail"].ToString();
            int id= context.Students.Where(x=>x.StudentEmail==values).Select(y=>y.StudentID).FirstOrDefault();
            var courseList = context.Processes.Where(x=>x.StudentID==id).ToList();
            return View(courseList);
        }
    }
}