using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarframeToDo.Objects.Items
{
    public class Patchlog
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public Nullable<DateTime> Date { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("additions")]
        public string Additions { get; set; }

        [JsonProperty("changes")]
        public string Changes { get; set; }

        [JsonProperty("fixes")]
        public string Fixes { get; set; }

        public Patchlog() { }
    }
}