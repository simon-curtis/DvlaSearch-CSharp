using Newtonsoft.Json;

namespace DvlaSearch_CSharp.FetchResponse
{
    internal class ErrorResponse
    {
        [JsonProperty("error")] public int ErrorNumber { get; set; } = -1;
        [JsonProperty("message")] public string Message { get; set; } = "";
    }
}