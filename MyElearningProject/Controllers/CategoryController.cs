﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult CategoryIndex()
        {
            return View();
        }
    }
}