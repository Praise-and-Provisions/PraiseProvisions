using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models
{
    public class CelebrityChef
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("firstName")]
        public string firstName { get; set; }

        [JsonProperty("lastName")]
        public string lastName { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

        [JsonProperty("favorites")]
        public string favorites { get; set; }
    }
}
