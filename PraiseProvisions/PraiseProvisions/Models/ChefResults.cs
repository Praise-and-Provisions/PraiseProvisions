using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models
{
    public class ChefResults
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("chefFirstName")]
        public string firstName { get; set; }

        [JsonProperty("chefLastName")]
        public string lastName { get; set; }

        [JsonProperty("restaurantName")]
        public string restaurantName { get; set; }

        [JsonProperty("address")]
        public string address { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

        [JsonProperty("review")]
        public string review { get; set; }
    }
}
