using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarframeToDo.Objects.Items
{
    public class Warframe
    {
        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("health")]
        public Nullable<int> Health { get; set; }

        [JsonProperty("shield")]
        public Nullable<int> Shield { get; set; }

        [JsonProperty("armor")]
        public Nullable<int> Armor { get; set; }

        [JsonProperty("stamina")]
        public Nullable<int> Stamina { get; set; }

        [JsonProperty("power")]
        public Nullable<int> Power { get; set; }

        [JsonProperty("masteryReq")]
        public Nullable<int> MasteryRequirement { get; set; }

        [JsonProperty("sprintSpeed")]
        public Nullable<double> SprintSpeed { get; set; }

        [JsonProperty("passiveDescription")]
        public string PassiveDescription { get; set; }

        [JsonProperty("abilities")]
        public List<WarframeAbility> Abilities { get; set; }

        [JsonProperty("productCategory")]
        public string ProductCategory { get; set; }

        [JsonProperty("buildPrice")]
        public Nullable<int> BuildPrice { get; set; }

        [JsonProperty("buildTime")]
        public Nullable<int> BuildTime { get; set; }

        [JsonProperty("skipBuildTimePrice")]
        public Nullable<int> SkipBuildTimePrice { get; set; }

        [JsonProperty("buildQuantity")]
        public Nullable<int> BuildQuantity { get; set; }

        [JsonProperty("consumeOnBuild")]
        public Nullable<Boolean> ConsumeOnBuild { get; set; }

        [JsonProperty("components")]
        public List<WarframeComponent> Components { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("tradable")]
        public Nullable<Boolean> Tradable { get; set; }

        [JsonProperty("patchlogs")]
        public List<Patchlog> Patchlogs { get; set; }

        [JsonProperty("aura")]
        public string Aura { get; set; }

        [JsonProperty("conclave")]
        public Nullable<Boolean> Conclave { get; set; }

        [JsonProperty("color")]
        public Nullable<int> Color { get; set; }

        [JsonProperty("introduced")]
        public string Introduced { get; set; }

        [JsonProperty("polarities")]
        public List<string> Polarities { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("sprint")]
        public Nullable<double> Sprint { get; set; }

        [JsonProperty("wikiaThumbnail")]
        public string WikiaThumbnail { get; set; }

        [JsonProperty("wikiaUrl")]
        public string WikiaUrl { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("vaultDate")]
        public string VaultDate { get; set; }

        [JsonProperty("estimatedVaultDate")]
        public string EstimatedVaultDate { get; set; }

        [JsonProperty("vaulted")]
        public Nullable<Boolean> Vaulted { get; set; }

        public Warframe()
        {
            Abilities = new List<WarframeAbility>();
            Components = new List<WarframeComponent>();
            Patchlogs = new List<Patchlog>();
            Polarities = new List<string>();
        }
    }
}