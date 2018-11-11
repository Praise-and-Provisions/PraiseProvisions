using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Controllers
{
    public class AboutUsController : Controller
    {
        /// <summary>
        /// Index page for the About US
        /// </summary>
        /// <returns>Returns the Index View</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
