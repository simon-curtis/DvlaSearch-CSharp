using System.Text.RegularExpressions;

namespace DvlaSearch_CSharp
{
    public static class Validation
    {
        public static readonly Regex DriverLicenceRegexp = new Regex(
            "[9A-Z]{5}[0-9]{6}[A-Z]{2}[0-9][A-Z]{2}");
        
        public static readonly Regex PostCodeRegexp = new Regex(
            @"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})
                |(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\\s?[0-9][A-Za-z]{2})");
        
        public static readonly Regex NiNumberRegex = new Regex(
            "[A-Z]{2}[0-9]{6}[A-Z]");
    }
}