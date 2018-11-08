using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PraiseProvisions.Models;
using PraiseProvisions.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Yelp;

namespace PraiseProvisions.Controllers
{
    [Route("[controller]")]
    public class ResultsController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Index(int userId, string search)
        {
            using (var chefClient = new HttpClient())
            {
                try
                {
                    //string tempCity = "seattle";//hard coded, will replace with text box input
                    chefClient.BaseAddress = new Uri("https://praiseapi.azurewebsites.net");
                    var response = await chefClient.GetAsync($"/api/recommendations");
                    response.EnsureSuccessStatusCode();

                    var chefResults = await response.Content.ReadAsStringAsync();

                    // required to convert to a List<CelebrityChef> since the json coming from API is numerous arrays from their database.
                    var rawChefRecommendations = JsonConvert.DeserializeObject<List<ChefResults>>(chefResults);

                    var yelpRequest = new Yelp.Api.Models.SearchRequest();
                    yelpRequest.Term = "restaurants";
                    yelpRequest.Location = search.ToLower();//hard coded, will replace with text box input
                    yelpRequest.MaxResults = 50;

                    var yelpClient = new Yelp.Api.Client("e0ZfT6muy7b6ZDYXAJVWjIx_oM4eCQSxVxaFGhjJSrLfHRoEX6XgUExr7DCGufP-WTImBXy150jg5eC12i5l2nVcLl5RvmZbck26hv6a_BpIvEhfOZc0YEfFPTfjW3Yx");
                    var yelpResults = await yelpClient.SearchBusinessesAllAsync(yelpRequest);
                    var rawYelpRecommendations = yelpResults.Businesses;

                    IEnumerable<ChefResults> filteredChefRecommendations = rawChefRecommendations.Where(x => x.city.ToLower() == search.ToLower());
                    List<ChefResults> combinedResults = new List<ChefResults>();

                    foreach(var item in rawYelpRecommendations)
                    {
                        foreach(var chefRec in rawChefRecommendations)
                        {
                            if(item.Name.ToLower() == chefRec.restaurantName.ToLower())
                            {
                                combinedResults.Add(chefRec);
                            }
                        }
                    }

                    int count = 0;
                    int index = 0;
                    int final = 10 - combinedResults.Count();

                    while (count < final && rawYelpRecommendations.ElementAt(index) != null)
                    {
                        bool isValid = true;
                        foreach(ChefResults cr in combinedResults)
                        {
                            if(cr.restaurantName.ToLower() == rawYelpRecommendations.ElementAt(index).Name.ToLower())
                            {
                                isValid = false;
                            }
                        }

                        if (isValid)
                        {
                            ChefResults yelpRest = new ChefResults
                            {
                                restaurantName = rawYelpRecommendations.ElementAt(index).Name,
                                description = rawYelpRecommendations.ElementAt(index).Categories[0].Title,
                                address = rawYelpRecommendations.ElementAt(index).Location.Address1
                            };
                            combinedResults.Add(yelpRest);
                            count++;
                        }
                        index++;
                    }
                    return View(new FavoritesCombined { UserID = userId, ResultsList = combinedResults });
                }
                catch (HttpRequestException e)
                {
                    return BadRequest($"Sorry, getting chef recommendations from PraiseAPI: {e.Message}");
                }

            }
        }
    }
}
