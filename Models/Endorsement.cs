using Newtonsoft.Json;

namespace DvlaSearch_CSharp.Models
{
    public abstract class Endorsement
    {
        [JsonProperty("category")] public string Category { get; set; } = "";
    }
}