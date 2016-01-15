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


            routes.MapRoute(
              name: "Route",
              url: "Route/Route/{id}",
              defaults: new { controller = "Route", action = "Route" }
          );


            routes.MapRoute(
               name: "RouteJs",
               url: "{area}/{controller}/Route/{action}"
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}"
                , defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
