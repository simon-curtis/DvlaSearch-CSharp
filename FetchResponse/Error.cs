namespace DvlaSearch_CSharp.FetchResponse
{
    public class Error : FetchResult
    {
        public string ErrorMessage { get; }
        public Error(string? errorMessage) => ErrorMessage = errorMessage ?? "Unknown Error";
    }
}