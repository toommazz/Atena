using Atena.Domain.Core.Data;

namespace Atena.Service.Interfaces
{
    public interface IAppService<TView> where TView : class
    {
        Task<PagedList<TView>> GetPaged(int page, int size, string orderProperty,
        bool orderCrescent);

        Task<TView> Get(Guid? id);

        Task Save(TView model);

        Task Remove(Guid? id);

        Task Update(TView model);
    }
}
