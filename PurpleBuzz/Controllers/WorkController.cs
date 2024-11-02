using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzz.Controllers
{
    public class WorkController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "Work";
            return View();
        }

    }
}
