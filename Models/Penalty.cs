using System;
using Newtonsoft.Json;

namespace DvlaSearch_CSharp.Models
{
    public class Penalty : Endorsement
    {
        [JsonProperty("expiryDate")] public DateTime ExpiryDate { get; set; }
        [JsonProperty("fine")] public float Fine { get; set; }
        [JsonProperty("offenceDate")] public DateTime OffenceDate { get; set; }
        [JsonProperty("penaltyPoint")] public int PenaltyPoint { get; set; }
        [JsonProperty("removalDate")] public DateTime RemovalDate { get; set; }
        [JsonProperty("state")] public string State { get; set; } = "";
    }
}