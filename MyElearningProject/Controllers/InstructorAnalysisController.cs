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
        [Authorize]
        public ActionResult InstructorAnalysisIndex()
        {
            return View();
        }
       public PartialViewResult InstructorPanelPartial()
        {
            int id = 1;
           var value = context.Instructors.Where(x=>x.InstructorID == id).ToList();
            var v1 = context.Instructors.Where(x => x.InstructorName == "Ahmet" && x.InstructorSurname == "Ölçen").Select(y => y.InstructorID).FirstOrDefault();
            ViewBag.courseCount = context.Courses.Where(x => x.InstructorID == 1).Count();
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(y => y.CourseID).ToList();
            ViewBag.commentCount = context.Comments.Where(x => v2.Contains(x.CourseID)).Count();

            return PartialView(value);
        }
        public PartialViewResult InstructorCommentPartial()
        {
            //v1 = select InstructorID from Instructor where InstructorName='Ahmet' and InstructorSurname='Ölçen'
            var v1 = context.Instructors.Where(x=> x.InstructorName == "Ahmet" && x.InstructorSurname=="Ölçen").Select(y=>y.InstructorID).FirstOrDefault();

            //v2= select CourseID from Course where InstructorID
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(y => y.CourseID).ToList();

            //v3= Select * from Comments where CourseID in 
            //contains= v2 den gelen listeyi CourseId ile eşleştir
            var v3 = context.Comments.Where(x => v2.Contains(x.CourseID)).ToList();

            return PartialView(v3);
        }
        public PartialViewResult CourseListByInstructorPartial()
        {
            var values= context.Courses.Where(x=>x.InstructorID==1).ToList();
            return PartialView(values);
        }
    }
}