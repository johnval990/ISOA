using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cotraser.Isoa.Web.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           routes.MapRoute(
               name: "Api",
               url: "Services/Api/{action}/{id}",
               defaults: new { controller = "Api", action = "Index", id = UrlParameter.Optional }
           );

           routes.MapRoute(
               name: "Admin_User",
               url: "Administracion/Usuarios/{id}",
               defaults: new { controller = "Admin", action = "Users", id = UrlParameter.Optional }
           );

           routes.MapRoute(
               name: "Admin_User_Detail",
               url: "Administracion/DealleUsuario/{id}",
               defaults: new { controller = "Admin", action = "UserDetail", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );

            

           /* routes.MapRoute(
                name: "Noticias",
                url: "test/Noticias/{action}/{id}/{id2}",
                defaults: new { controller = "Noticias", action = "Index", id = UrlParameter.Optional, id2 = UrlParameter.Optional }
            );*/
        }
    }
}