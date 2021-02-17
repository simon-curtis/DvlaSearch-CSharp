using System.Runtime.InteropServices;

namespace DvlaSearch_CSharp.FetchResponse
{
    public class Success<T> : FetchResult
    {
        public T Content { get; set; }
        public Success(T content) => Content = content;
        
        public void Deconstruct(out T content) => content = Content;
    }
}