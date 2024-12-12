using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class ContactPageController : Controller
    {
        ELearningContext context=new ELearningContext();
        [HttpGet]
        public ActionResult ContactPageIndex()
        {
            var value= context.Addresses.ToList();
            return View(value);
        }
        [HttpPost]
        public ActionResult ContactPageIndex(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("PageIndex", "Default");
        }
    }
}