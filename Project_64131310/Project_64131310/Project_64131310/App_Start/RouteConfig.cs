using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Project_64131310
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            

            routes.MapRoute(
                name: "CheckOut",
                url: "thanh-toan",
                defaults: new { controller = "ShoppingCart_64131310", action = "CheckOut", alias = UrlParameter.Optional },
                namespaces: new[] { "Project_64131310.Controllers" }
            );

            routes.MapRoute(
                name: "ShoppingCart",
                url: "gio-hang",
                defaults: new { controller = "ShoppingCart_64131310", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "Project_64131310.Controllers" }
            );

            routes.MapRoute(
                name: "detailProduct",
                url: "chi-tiet/{alias}-p{id}",
                defaults: new { controller = "Products_64131310", action = "Detail", alias = UrlParameter.Optional },
                namespaces: new[] { "Project_64131310.Controllers" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "lien-he",
                defaults: new { controller = "Contact_64131310", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "Project_64131310.Controllers" }
            );

            routes.MapRoute(
                name: "CategoryProduct",
                url: "danh-muc-san-pham/{alias}-{id}",
                defaults: new { controller = "Products_64131310", action = "ProductCategory", id = UrlParameter.Optional },
                namespaces: new[] { "Project_64131310.Controllers" }
            );

            routes.MapRoute(
                name: "Products",
                url: "san-pham",
                defaults: new { controller = "Products_64131310", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "Project_64131310.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Project_64131310.Controllers" }
            );
        }
    }
}
