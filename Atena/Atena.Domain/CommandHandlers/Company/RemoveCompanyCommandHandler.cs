using Atena.Domain.Commands.Company;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers.Login
{
    public class RemoveCompanyCommandHandler : CommandHandlerRemove<RemoveCompanyCommand, Company, RemovedCompanyEvent>
    {
        public RemoveCompanyCommandHandler(IMediatorHandler mediator, IMapper mapper, Core.Repositories.IRepository<Company> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
