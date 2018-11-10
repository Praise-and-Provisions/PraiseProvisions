using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models
{
    public class UserProfile
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "")]
        public string fullName { get; set; }

        public ICollection<UserFavorite> UserFavorites { get; set; }
    }
}
