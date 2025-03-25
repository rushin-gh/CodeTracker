using System.Web.Mvc;
using CodeTracker.Business;
using CodeTracker.Models.User;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService _loginServiceInstance = new LoginService();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(EndUser endUser)
        {
            int endUserId = _loginServiceInstance.GetUserID(endUser);
            if (endUserId != 0)
            {
                endUser.EndUserUserid = endUserId;
                Session["EndUser"] = endUser;
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index");
        }
    }
}