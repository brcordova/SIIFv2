using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIFFv2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string userid = HttpContext.User.Identity.Name; // use this to get the client userid
            string usr = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            //User.Identity.IsAuthenticated = true;
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}