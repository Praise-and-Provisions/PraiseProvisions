using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models
{
    public class UserFavorite
    {
        public int UserProfileID { get; set; }
        public int RestaurantID { get; set; }

        public UserProfile UserProfile { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
