using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DvlaSearch_CSharp.Models
{
    public abstract class DriverLicence
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
        public ICollection<VehicleCategory> VehicleCategories { get; set; } = Array.Empty<VehicleCategory>();

        [JsonProperty("penalties")] public ICollection<Penalty> Penalties { get; set; } = Array.Empty<Penalty>();

        [JsonProperty("disqualifications")]
        public ICollection<Disqualification> Disqualifications { get; set; } = Array.Empty<Disqualification>();

        public DigitalTachograph? DigitalTachograph { get; set; }
    }
}