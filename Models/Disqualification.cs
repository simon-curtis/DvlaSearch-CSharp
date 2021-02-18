using System;
using Newtonsoft.Json;

namespace DvlaSearch_CSharp.Models
{
    public class Disqualification : Endorsement
    {
        [JsonProperty("convictionDate")] public DateTime ConvictionDate { get; set; }
        [JsonProperty("endDate")] public DateTime EndDate { get; set; }
        [JsonProperty("fine")] public float Fine { get; set; }
        [JsonProperty("removalDate")] public DateTime RemovalDate { get; set; }
        [JsonProperty("startDate")] public DateTime StartDate { get; set; }
        [JsonProperty("period")] public string Period { get; set; } = "";
    }
}