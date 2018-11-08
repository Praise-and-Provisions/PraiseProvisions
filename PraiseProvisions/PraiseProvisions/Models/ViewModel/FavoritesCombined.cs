using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models.ViewModel
{
    public class FavoritesCombined
    {
        public int UserID { get; set; }
        public List<ChefResults> ResultsList { get; set; }
    }
}
