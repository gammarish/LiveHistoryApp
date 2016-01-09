﻿using LiveHistory.Common;
using LiveHistory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveHistory.Controllers
{
    public class HomeController : Controller
    {
        MainDBContext context = new MainDBContext();

        // GET: Home
        public ActionResult Index()
        {

            ViewBag.Title = "Home Page";
            return View();
        }

        public JsonResult GetDetailsForMarkers()
        {
            RouteModel model = new RouteModel();

            model.Points = GetCollectionOfPoints();
            return new JsonResult() { Data = new ResultType<List<PointModel>>(model.Points), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        private List<PointModel> GetCollectionOfPoints()
        {
            PointModel points = new PointModel();


            List<PointModel> empList = context.Point.ToList();
            return empList;
        }
    }
}