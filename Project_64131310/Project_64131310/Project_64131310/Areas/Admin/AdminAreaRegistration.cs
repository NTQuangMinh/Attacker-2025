using System.Web.Mvc;

namespace Project_64131310.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin"; // Tên của area
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Home_64131310", action = "Index", id = UrlParameter.Optional },
                new[] { "Project_64131310.Areas.Admin.Controllers" } // Namespace controller trong Admin
            );
        }
    }
}