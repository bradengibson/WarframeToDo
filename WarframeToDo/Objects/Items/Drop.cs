using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarframeToDo.Objects.Items
{
    public class Drop
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("chance")]
        public Nullable<double> Chance { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        public Drop() { }
    }
}