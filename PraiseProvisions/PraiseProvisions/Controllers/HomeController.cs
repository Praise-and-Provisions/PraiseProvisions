using Microsoft.AspNetCore.Mvc;

namespace PraiseProvisions.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserIndex(int userID)
        {
            ViewData["userId"] = userID;
            return View("Views/Home/Index.cshtml");
        }
    }
}
