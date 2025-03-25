using System.Web.Mvc;
using CodeTracker.Util;
using CodeTracker.Models.User;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EndUser endUser = Session["EndUser"] as EndUser;
            if (General.IsNull(endUser))
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}