using System;
using Newtonsoft.Json;

namespace DvlaSearch_CSharp.Models
{
    public abstract class VehicleCategory
    {
        [JsonProperty("category")] public string Category { get; set; } = "";
        [JsonProperty("endDate")] public DateTime EndDate { get; set; }
        [JsonProperty("provisional")] public bool Provisional { get; set; }
        [JsonProperty("startDate")] public DateTime StartDate { get; set; }

        [JsonProperty("restrictionDescription")]
        public string RestrictionDescription { get; set; } = "";
    }
}