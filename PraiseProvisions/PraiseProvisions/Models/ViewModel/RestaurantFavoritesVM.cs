using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models.ViewModel
{
    public class RestaurantFavoritesVM
    {
        public int UserID { get; set; }
        
        public string firstName { get; set; }
        
        public string lastName { get; set; }
        
        public string restaurantName { get; set; }
        
        public string address { get; set; }
        
        public string description { get; set; }
        
        public string city { get; set; }
        
        public string review { get; set; }
    }
}
