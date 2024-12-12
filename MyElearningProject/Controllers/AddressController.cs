using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class AddressController : Controller
    {
       ELearningContext context= new ELearningContext();
        [Authorize]
        public ActionResult AddressIndex()
        {
            var value= context.Addresses.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult UpdateAddress(int id)
        {
            var value = context.Addresses.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAddress (Address address)
        {
            var value = context.Addresses.Find(address.AddressID);
            value.AddressDescription = address.AddressDescription;
            value.AddressPhone = address.AddressPhone;
            value.AddressDetail = address.AddressDetail;
            value.AddressMail = address.AddressMail;
            context.SaveChanges();
            return RedirectToAction("AddressIndex");
        }
    }
}