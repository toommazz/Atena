using System.Text.Json.Serialization;

namespace Atena.Domain.Core.Data
{
    public class PagedList<TEntity> where TEntity : class
    {
        public PagedList() { }

         public PagedList(IList<TEntity> results) 
        {
            Results = results;
        }

        public int TotalRecords { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public int TotalPages { get; set; }

        public IList<TEntity> Results { get; set; }
        
        public int FirstRecordOnPage
        {
            get { return TotalRecords > 0 ? (CurrentPage - 1) * PageSize + 1 : 0; }
        }

        public int LastRecordOnPage
        {
            get { return Math.Min(CurrentPage + 1, TotalRecords); }
        }

        [JsonIgnore]
        public Page Page { get; set; }

        [JsonIgnore]
        public Order Order { get; set; }

    }

}
