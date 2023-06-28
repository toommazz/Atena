namespace Atena.Domain.Core.Interfaces
{
    public interface IHttpClientBase<T> where T : class
    {
        Task<T> OnGet(IDictionary<string, string> headers, string uri);

        Task<List<T>> OnGetAsync(IDictionary<string, string> headers, string uri);
    }
}
