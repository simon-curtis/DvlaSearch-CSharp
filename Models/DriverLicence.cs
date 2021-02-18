using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DvlaSearch_CSharp.Models
{
    public class DriverLicence
    {
        [JsonProperty("name")] public string Name { get; set; } = "";

        [JsonProperty("dob")] public DateTime DateOfBirth { get; set; }

        [JsonProperty("gender")] public string Gender { get; set; } = "";

        [JsonProperty("address")] public string Address { get; set; } = "";

        [JsonProperty("validFrom")] public DateTime ValidFrom { get; set; }

        [JsonProperty("validTo")] public DateTime ValidTo { get; set; }

        [JsonProperty("licenceNumber")] public string LicenceNumber { get; set; } = "";

        [JsonProperty("issueNumber")] public string IssueNumber { get; set; } = "";

        [JsonProperty("penaltyPoints")] public int PenaltyPoints { get; set; }

        [JsonProperty("vehicleCategories")]
        public ICollection<VehicleCategory> VehicleCategories { get; set; } = new List<VehicleCategory>();

        [JsonProperty("penalties")] public ICollection<Penalty> Penalties { get; set; } = new List<Penalty>();

        [JsonProperty("disqualifications")]
        public ICollection<Disqualification> Disqualifications { get; set; } = new List<Disqualification>();

        public DigitalTachograph? DigitalTachograph { get; set; }
    }
}