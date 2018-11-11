using Microsoft.AspNetCore.Mvc;

namespace PraiseProvisions.Controllers
{
    public class HomeController:Controller
    {
        /// <summary>
        /// Praise and provisions Index page
        /// </summary>
        /// <returns>Returns the Index view</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// User taken here when first entering site, requests a user id
        /// </summary>
        /// <param name="userID"># associated to the userID</param>
        /// <returns>Returns the Index view</returns>
        public IActionResult UserIndex(int userID)
        {
            ViewData["userId"] = userID;
            return View("Views/Home/Index.cshtml");
        }
    }
}
