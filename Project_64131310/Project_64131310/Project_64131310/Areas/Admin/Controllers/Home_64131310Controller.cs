using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_64131310.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin,Employee")]
    public class Home_64131310Controller : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}