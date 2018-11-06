using PraiseProvisions.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models.Services
{
    public class RestaurantServices : IRestaurant
    {
        public Task CreateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRestaurant(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant> GetRestaurant(int? ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Restaurant>> GetRestaurants()
        {
            throw new NotImplementedException();
        }

        public Task UpdateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
