using DvlaSearch_CSharp.FetchResponse;

namespace DvlaSearch_CSharp
{
    public interface IDvlaSearchHelper
    {
        FetchResult GetDriverLicence(
            string licenceNumber, string nationalInsuranceNumber, string postCode);
    }
}