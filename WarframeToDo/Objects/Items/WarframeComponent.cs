using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarframeToDo.Objects.Items
{
    public class WarframeComponent
    {
        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("itemCount")]
        public Nullable<int> ItemCount { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("tradable")]
        public Nullable<Boolean> Tradable { get; set; }

        [JsonProperty("primeSellingPrice")]
        public Nullable<int> PrimeSellingPrice { get; set; }

        [JsonProperty("ducats")]
        public Nullable<int> Ducats { get; set; }

        [JsonProperty("drops")]
        public List<Drop> Drops { get; set; }

        public WarframeComponent()
        {
            Drops = new List<Drop>();
        }
    }
}