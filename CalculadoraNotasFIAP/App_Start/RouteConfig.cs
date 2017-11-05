using System.Web.Mvc;
using System.Web.Routing;

namespace CalculadoraNotasFIAP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "rm",
                url: "{controller}/{action}/{rm}",
                defaults: new { controller = "Home", action = "Index", rm = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
