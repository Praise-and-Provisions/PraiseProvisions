using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models.Interfaces
{
    public interface IRestaurant
    {
        //Create
        Task CreateRestaurant(Restaurant restaurant);

        //Updating
        Task UpdateRestaurant(Restaurant restaurant);

        //Deleting
        Task DeleteRestaurant(int ID);

        //Reading
        Task<List<Restaurant>> GetRestaurants(); //gets all restaurants
        Task<Restaurant> GetRestaurant(int? ID); //gets a single restaurant
    }
}
