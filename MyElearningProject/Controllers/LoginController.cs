using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyElearningProject.Controllers
{
    public class LoginController : Controller
    {
        ELearningContext context= new ELearningContext();
        [HttpGet]
        public ActionResult LoginIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginIndex(Student student)
        {
            var values = context.Students.FirstOrDefault(x => x.StudentEmail == student.StudentEmail && x.StudentPassword == student.StudentPassword);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.StudentEmail, false);
                //session propartysi diğer sayfalara taşımak için kullanılır
                Session["CurrentMail"]=values.StudentEmail;
                //oturum açık kalma süresi dakika türünde
                Session.Timeout = 60;
                return RedirectToAction("ProfileIndex","Profile");
            }
            return View();
        }
    }
}