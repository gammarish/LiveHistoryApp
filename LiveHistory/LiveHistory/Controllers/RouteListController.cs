using LiveHistory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveHistory.Controllers
{
    public class RouteListController : Controller
    {
        MainDBContext context = new MainDBContext();

        // GET: RouteList
        public ActionResult RouteList()
        {
            ViewBag.RouteList = GetRoutes();
            ViewBag.CityList = GetCities();
            return View(ViewBag);
        }


        public List<RouteModel> GetRoutes()
        {
            List<RouteModel> list = context.Route.ToList();
            return list;
        }

        public List<CityModel> GetCities()
        {

            List<CityModel> list = context.City.ToList();
            return list;
        }
    }
}