using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebCNPM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MyMy",
                url: "CAUTHU_GHIBAN/{action}/{id}",
                defaults: new {controller = "CAUTHU_GHIBAN" , action = "Index" , id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "CauThu",
                url: "CAUTHU/{action}/{id}",
                defaults: new { controller = "CAUTHU", action = "Index", id = UrlParameter.Optional }
                );
        }


    }
}
