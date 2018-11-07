using Microsoft.AspNetCore.Mvc;
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

                    return Ok(stringResult);
                }
                catch (HttpRequestException e)
                {
                    return BadRequest($"Sorry, getting chefs from PraiseAPI: {e.Message}");
                }
            }
        }
    }
}
