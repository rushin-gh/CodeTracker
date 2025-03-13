using System.Web.Mvc;
using CodeTracker.Models.User;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            EndUser endUser = new EndUser();
            return View(endUser);
        }
    }
}