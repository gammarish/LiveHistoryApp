﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveHistory.Controllers
{
    public class RouteDetailsController : Controller
    {
        // GET: RouteDetails
        public ActionResult RouteDetails(int id)
        {
            ViewBag.RouteId = id;
            return View(ViewBag);
        }
    }
}