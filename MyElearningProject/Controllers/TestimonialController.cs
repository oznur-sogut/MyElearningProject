using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class TestimonialController : Controller
    {
        ELearningContext context= new ELearningContext();
        public ActionResult TestimonialIndex()
        {
            var value= context.Testimonials.ToList();
            return View(value);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value= context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value=context.Testimonials.Find(testimonial.TestimonialID);
            value.TestimonialNameSurname = testimonial.TestimonialNameSurname;
            value.TestimonialTitle = testimonial.TestimonialTitle;
            value.TestimonialComment = testimonial.TestimonialComment;
            value.TestimonialImageUrl = testimonial.TestimonialImageUrl;
            value.TestimonialStatus = testimonial.TestimonialStatus;
            context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }
        public ActionResult StatusIsTrue(int id)
        {
            var value = context.Testimonials.Find(id);
            value.TestimonialStatus = true;
            context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }
        public ActionResult StatusIsFalse(int id)
        {
            var value = context.Testimonials.Find(id);
            value.TestimonialStatus = false;
            context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }
        public ActionResult DetailTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }
    }
}