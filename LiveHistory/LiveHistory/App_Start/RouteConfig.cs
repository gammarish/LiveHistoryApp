using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LiveHistory
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //routes.MapRoute(
            //   name: "Contact",
            //   url: "{controller}/{action}",
            //   defaults: new { controller = "Contact", action = "Contact", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Ranking",
            //    url: "{controller}",
            //    defaults: new { controller = "Ranking", action = "Ranking", id = UrlParameter.Optional }
            // );

            routes.MapRoute(
                name: "Route",
                url: "Route/{controller}/{action}",
                defaults: new { controller = "Route", action = "Route", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Route2",
               url: "{controller}/{action}",
               defaults: new { controller = "Route", action = "Route", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );




        }
    }
}
