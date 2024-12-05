using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class AboutController : Controller
    {
        ELearningContext context= new ELearningContext();
        public ActionResult AboutIndex()
        {
            var value= context.Abouts.ToList();
            return View(value);
        }
        public ActionResult DeleteAbout (int id)
        {
            var value = context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value= context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value= context.Abouts.Find(about.AboutID);
            value.AboutTitle = about.AboutTitle;
            value.AboutSubtitle = about.AboutSubtitle;
            value.AboutIcon = about.AboutIcon;
            context.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
    }
}