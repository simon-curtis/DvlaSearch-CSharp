namespace DvlaSearch_CSharp.FetchResponse
{
    public class Success<T> : FetchResult
    {
        public Success(T content)
        {
            Content = content;
        }

        public T Content { get; set; }

        public void Deconstruct(out T content)
        {
            content = Content;
        }
    }
}