using Microsoft.EntityFrameworkCore;
using PraiseProvisions.Data;
using PraiseProvisions.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models.Services
{
    public class RestaurantServices : IRestaurant
    {
        private PraiseProvisionDbContext _context;

        public RestaurantServices(PraiseProvisionDbContext context)
        {
            _context = context;
        }

        public async Task CreateRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRestaurant(int ID)
        {
            Restaurant restaurant = await GetRestaurant(ID);
            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task<Restaurant> GetRestaurant(int? ID)
        {
            return await _context.Restaurants.FirstOrDefaultAsync(x => x.ID == ID);
        }

        public async Task<List<Restaurant>> GetRestaurants()
        {
            return await _context.Restaurants.ToListAsync();
        }

        public async Task UpdateRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Update(restaurant);
            await _context.SaveChangesAsync();
        }
    }
}
