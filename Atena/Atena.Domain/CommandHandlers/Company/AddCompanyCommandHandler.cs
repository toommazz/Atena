using Atena.Domain.Commands.Company;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers.Login
{
    public class AddCompanyCommandHandler : CommandHandlerAdd<AddCompanyCommand, Company, AddedCompanyEvent>
    {
        public AddCompanyCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<Company> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
