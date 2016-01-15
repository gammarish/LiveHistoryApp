using LiveHistory.Common;
using LiveHistory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveHistory.Controllers
{
    public class RouteController : Controller
    {
        MainDBContext context = new MainDBContext();

        private int routeId;

        public int RouteId
        {
            get { return routeId; }
            set { routeId = value; }
        }
        
        public ActionResult Route(int id)
        {
            RouteId = id;
            return View();
        }

        public JsonResult GetDetailsForMarkers()
        {
            RouteModel model = new RouteModel();

            model.Points = GetCollectionOfPoints(RouteId);
            return new JsonResult() { Data = new ResultType<List<PointModel>>(model.Points), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        private List<PointModel> GetCollectionOfPoints(int id)
        {
            PointModel points = new PointModel();


            List<PointModel> empList = context.Point.Where(x=>x.Route_Id == id).ToList();
            return empList;
        }
    }
}