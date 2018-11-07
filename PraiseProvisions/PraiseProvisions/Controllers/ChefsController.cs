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
                    var rawChefs = JsonConvert.DeserializeObject<CelebrityChef>(stringResult);
                    int i = 0;
                    return Ok(new {
                        id = rawChefs.ID,
                        FirstName = rawChefs.firstName,
                        LastName = rawChefs.lastName,
                        City = rawChefs.city,
                        Favorites = rawChefs.favorites
                    });
                }
                catch (HttpRequestException e)
                {
                    return BadRequest($"Sorry, getting chefs from PraiseAPI: {e.Message}");
                }
            }
        }
    }
}
