using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MotManager.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // attribute routing
            routes.MapMvcAttributeRoutes();
            // traditional routing
            RegisterTraditionalRoutes(routes);
        }

        /// <summary> Unit testable method - only traditional routes can be unit tested
        /// </summary>
        public static void RegisterTraditionalRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
