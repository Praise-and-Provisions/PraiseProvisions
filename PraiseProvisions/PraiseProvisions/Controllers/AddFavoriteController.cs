using Microsoft.AspNetCore.Mvc;
using PraiseProvisions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PraiseProvisions.Controllers
{
    [Route("[controller]")]
    public class AddFavoriteController : Controller 
    {
        [HttpPost]
        public IActionResult Index(int id, ChefResults chefResults)
        {
            return Ok();
        }
    }
}
