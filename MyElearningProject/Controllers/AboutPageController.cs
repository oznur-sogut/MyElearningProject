using MyElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class AboutPageController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult AboutPageIndex()
        {
            return View();
        }
    }
}