using MyElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class ContactController : Controller
    {
        ELearningContext context=new ELearningContext();
        [Authorize]
        public ActionResult ContactIndex()
        {
            var value= context.Contacts.ToList();
            return View(value);
        }
        public ActionResult DeleteContact(int id)
        {
            var value= context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ContactIndex");
        }
    }
}