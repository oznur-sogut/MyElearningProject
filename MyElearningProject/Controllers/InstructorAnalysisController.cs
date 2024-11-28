using MyElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class InstructorAnalysisController : Controller
    {
        ELearningContext context= new ELearningContext();
        public ActionResult InstructorAnalysisIndex()
        {
            return View();
        }
       public PartialViewResult InstructorPanelPartial()
        {
            int id = 1;
           var value = context.Instructors.Where(x=>x.InstructorID == id).ToList();
            return PartialView(value);
        }
        public PartialViewResult InstructorCommentPartial()
        {
            return PartialView();
        }
    }
}