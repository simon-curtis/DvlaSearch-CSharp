using System.Collections.Generic;

namespace DvlaSearch_CSharp.Models
{
    public static class Categories
    {
        public static readonly IDictionary<string, string> VehicleCategories = new Dictionary<string, string>
        {
            {"A1", "Light motorcycles"},
            {"A", "Motorcycles up to 25kW(33bhp)"},
            {"A", "Any size motorcycle with or without a sidecar."},
            {"B1", "Motor tricycles / quad cycles, 3 or 4 wheeled vehicles "},
            {"B", "Motor vehicles max 8 passenger with not exceeding 3500kg seats with a trailer up to 750kg."},
            {"B Automatic", "As cars, but with automatic transmission."},
            {"B+E", "Combinations of vehicles consisting of a vehicle in category B and a trailer"},
            {"C1", "Lorries between 3500kg and 7500kg with a trailerup to 750kg."},
            {"C1+E", "Lorries between 3500kg and 7500kg with a trailer between 750kg and 12000kg"},
            {"C", "Vehicles over 3500kg with a trailer up to 750kg."},
            {"C+E", "Vehicles over 3500kg with a trailer over 750kg."},
            {"D1", "Vehicles with between 9 and 16 passenger seats with a trailer up to 750kg."},
            {"D1+E", "Towing vehicle in subcategory D1 and its trailer has a MAM of between 750kg and 12000kg"},
            {"D", "Any bus with more than 8 passenger seats with a trailer up to 750kg."},
            {"D+E", "Any bus with more than 8 passenger seats with a trailer over 750kg."},
            {"F", "Agricultural tractors"},
            {"G", "Road Rollers"},
            {"H", "Tracked Vehicles"},
            {"K", "Mowing machine or vehicle controlled by a pedestrian"},
            {"L", "Electric vehicles"},
            {"N", "Vehicles used for very short distances on public roads"},
            {"P", "Mopeds"}
        };
    }
}