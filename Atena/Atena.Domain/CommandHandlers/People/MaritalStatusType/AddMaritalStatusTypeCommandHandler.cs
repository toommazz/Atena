using Atena.Domain.Commands.People.MaritalType;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class AddMaritalStatusTypeCommandHandler : CommandHandlerAdd<AddMaritalStatusTypeCommand, MaritalStatusType, AddedMaritalStatusTypeEvent>
    {
        public AddMaritalStatusTypeCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<MaritalStatusType> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
