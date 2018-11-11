using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseProvisions.Data;
using PraiseProvisions.Models;
using PraiseProvisions.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PraiseProvisions.Controllers
{
    public class AddFavoriteController : Controller 
    {
        private readonly PraiseProvisionDbContext _context;
        public AddFavoriteController(PraiseProvisionDbContext context)
        {

            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Index(int id, string firstName, string lastName, string restaurantName, string address, string description, string review)
        {
            Restaurant restaurantAdded = new Restaurant
            {
                Name = restaurantName,
                Address = address,
                Description = description
            };

            await _context.Restaurants.AddAsync(restaurantAdded);
            await _context.SaveChangesAsync();

            Restaurant restaurant = await _context.Restaurants.FirstOrDefaultAsync(x => x.Name == restaurantAdded.Name);

            await _context.UserFavorites.AddAsync(new UserFavorite
            {
                UserProfileID = id,
                RestaurantID = restaurant.ID
            });

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "UserFavorites", new { id });
        }
    }
}
