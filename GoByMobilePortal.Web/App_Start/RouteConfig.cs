using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GoByMobilePortal.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CityRoute",
                url: "{cityName}",
                defaults: new { controller = "Home", action = "RedirectCustomeCityAction", cityName = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CityServiceRoute",
                 url: "{cityName}/{serviceName}",
                defaults: new { controller = "Home", action = "RedirectCustomeCityResturentAction", cityName = UrlParameter.Optional, serviceName = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}