using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PraiseProvisions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PraiseProvisions.Controllers
{
    [Route("[controller]")]
    public class ChefsController : Controller
    {
        [HttpGet("chef")]
        public async Task<IActionResult> Chef()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://praiseapi.azurewebsites.net");
                    var response = await client.GetAsync($"/api/chef");
                    response.EnsureSuccessStatusCode();
                 
                    var stringResult = await response.Content.ReadAsStringAsync();

                    // required to convert to a List<CelebrityChef> since the json coming from API is numerous arrays from their database.
                    var rawChefs = JsonConvert.DeserializeObject<List<CelebrityChef>>(stringResult);

                    //send chefs to view
                    return View(rawChefs);
                }
                catch (HttpRequestException e)
                {
                    return BadRequest($"Sorry, getting chefs from PraiseAPI: {e.Message}");
                }
            }
        }
    }
}
