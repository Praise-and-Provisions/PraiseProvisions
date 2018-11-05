using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisionsAPI.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public IEnumerable<Favorites> Favorites { get; set; }
    }
}
