using System;
using Newtonsoft.Json;

namespace DvlaSearch_CSharp.Models
{
    public class DigitalTachograph
    {
        [JsonProperty("currentCardStatus")] public string CurrentCardStatus { get; set; } = "";
        [JsonProperty("validFrom")] public DateTime ValidFrom { get; set; }
        [JsonProperty("validTo")] public DateTime ValidTo { get; set; }
        [JsonProperty("cardNumber")] public string CardNumber { get; set; } = "";
    }
}