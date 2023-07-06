using Atena.Domain.Core.Interfaces;
using Atena.Infra.Contexts.Base;

namespace Atena.Infra.Repositories.Base
{
    public class UnityOfWork : IUnitOfWork, IDisposable
    {
        private readonly AtenaDataContext _context;

        public UnityOfWork(AtenaDataContext context)
        {
            _context = context;
        }

        public async Task<bool> CommitAsync()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                bool success = (await _context.SaveChangesAsync()) > 0;

                if (success)
                {
                    await transaction.CommitAsync();
                }
                else
                {
                    await transaction.RollbackAsync();
                }

                return success;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
