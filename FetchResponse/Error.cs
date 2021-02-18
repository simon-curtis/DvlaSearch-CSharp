namespace DvlaSearch_CSharp.FetchResponse
{
    public class Error : FetchResult
    {
        public Error(string? errorMessage)
        {
            ErrorMessage = errorMessage ?? "Unknown Error";
        }

        public string ErrorMessage { get; }
    }
}