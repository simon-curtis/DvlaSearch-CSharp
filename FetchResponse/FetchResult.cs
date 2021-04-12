namespace DvlaSearch_CSharp.FetchResponse
{
    public abstract class FetchResult
    {
    }
    
    public class Error : FetchResult
    {
        public Error(string? errorMessage)
        {
            ErrorMessage = errorMessage ?? "Unknown Error";
        }

        public string ErrorMessage { get; }
    }
    
    public class NotFound : FetchResult
    {
    }
    
    public class Success<T> : FetchResult
    {
        public Success(T content)
        {
            Content = content;
        }

        public T Content { get; set; }
    }
}