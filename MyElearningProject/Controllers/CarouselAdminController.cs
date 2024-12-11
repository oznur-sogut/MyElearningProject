using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class CarouselAdminController : Controller
    {
        ELearningContext context= new ELearningContext();
        public ActionResult CarouselIndex()
        {
            var value= context.Carousels.ToList();
            return View(value);
        }
        public ActionResult DeleteCarousel(int id)
        {
            var value = context.Carousels.Find(id);
            context.Carousels.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CarouselIndex");
        }
        [HttpGet]
        public ActionResult UpdateCarousel(int id)
        {
            var value=context.Carousels.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCarousel(Carousel carousel)
        {
            var value = context.Carousels.Find(carousel.CarouselID);
            value.CarouselDescription = carousel.CarouselDescription;
            value.CarouselTitle=carousel.CarouselTitle;
            value.CarouselImageUrl=carousel.CarouselImageUrl;
            context.SaveChanges();
            return RedirectToAction("CarouselIndex");
        }
        [HttpGet]
        public ActionResult AddCarousel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCarousel(Carousel carousel)
        {
            context.Carousels.Add(carousel);
            context.SaveChanges();
            return RedirectToAction("CarouselIndex");
        }
    }
}