using System.Web.Mvc;
using CodeTracker.Business;
using CodeTracker.Models.User;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginActivities _loginActivitiesInstance = new LoginActivities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(EndUser endUser)
        {
            endUser = _loginActivitiesInstance.GetUser(endUser);
            return RedirectToAction("Index");
        }
    }
}