using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DvlaSearch_CSharp.FetchResponse;
using DvlaSearch_CSharp.Models;
using Newtonsoft.Json;

namespace DvlaSearch_CSharp
{
    public class DvlaSearchHelper : IDvlaSearchHelper
    {
        private readonly string _apiApiKey;
        private readonly HttpClient _client;

        public DvlaSearchHelper(string apiKey)
        {
            _apiApiKey = apiKey;
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://dvlasearch.appspot.com")
            };
        }

        public FetchResult GetDriverLicence(
            string licenceNumber, string nationalInsuranceNumber, string postCode)
        {
            foreach (var (param, desc, regExp) in new[]
            {
                (licenceNumber, "Licence Number", Validation.DriverLicenceRegexp),
                (nationalInsuranceNumber, "National Insurance Number", Validation.NiNumberRegex),
                (postCode, "Post Code", Validation.PostCodeRegexp)
            })
            {
                if (string.IsNullOrEmpty(param))
                    return new Error($"Paramter '{desc}' is required");

                if (!regExp.IsMatch(param))
                    return new Error($"'{param}' was not a valid {desc}");
            }

            return Fetch<DriverLicence>("DriverLicence", new[]
            {
                $"licenceNo={licenceNumber}",
                $"natsInsNo={nationalInsuranceNumber}",
                $"postcode={postCode}"
            }).Result;
        }

        private async Task<FetchResult> Fetch<T>(string service, IEnumerable<string> parameters)
        {
            var query = $"?apikey={_apiApiKey}" + string.Concat(parameters.Select(p => $"&{p}"));
            HttpResponseMessage? response = await _client.GetAsync(service + query);

            if (!response.IsSuccessStatusCode) return new Error(response.ReasonPhrase ?? "Unknown Reason");

            var content = await response.Content.ReadAsStringAsync();

            if (content.Contains("\"error\":"))
            {
                ErrorResponse? error = JsonConvert.DeserializeObject<ErrorResponse>(content);
                return error!.ErrorNumber switch
                {
                    0 => new NotFound(),
                    _ => new Error(error!.Message)
                };
            }

            T obj;
            try
            {
                obj = JsonConvert.DeserializeObject<T>(content);
            }
            catch (Exception ex)
            {
                return new Error(ex.Message);
            }

            if (obj == null)
                return new Error("The result of the JSON parsing was null");

            return new Success<T>(obj);
        }
    }
}