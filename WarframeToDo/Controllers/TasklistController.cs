﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarframeToDo.Controllers
{
    public class TasklistController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}