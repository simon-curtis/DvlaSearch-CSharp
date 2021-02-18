using System.Text.RegularExpressions;

namespace DvlaSearch_CSharp
{
    public static class Validation
    {
        public static Regex DriverLicenceRegexp => new Regex(
            "[9A-Z]{5}[0-9]{6}[A-Z]{2}[0-9][A-Z]{2}");

        public static Regex PostCodeRegexp => new Regex(
            @"[a-zA-Z]{1,2}([0-9]{1,2}|[0-9][a-zA-Z])\s*[0-9][a-zA-Z]{2}");

        public static Regex NiNumberRegex => new Regex(
            "[A-Z]{2}[0-9]{6}[A-Z]");
    }
}