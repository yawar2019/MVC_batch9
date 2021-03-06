﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_batch9
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapMvcAttributeRoutes();


            routes.MapRoute(
              name: "Default1",
              url: "Sweet/Gulabjamun",
              defaults: new { controller = "Default", action = "getMeView", id = UrlParameter.Optional }
          );


            routes.MapRoute(
              name: "Default2",
              url: "Sweet/barfi",
              defaults: new { controller = "Default", action = "getMeView", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}/{name}",
               defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional }
           );


        }
    }
}
