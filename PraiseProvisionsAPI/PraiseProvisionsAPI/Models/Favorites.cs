using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisionsAPI.Models
{
    public class Favorites
    {
        public int ChefID { get; set; }
        public int RestaurantID { get; set; }

        public Chef Chef { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
