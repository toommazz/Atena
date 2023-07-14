using Atena.Domain.Commands.People.GenderType;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Event;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class UpdateGenderTypeCommandHandler : CommandHandlerUpdate<UpdateGenderTypeCommand, GenderType, UpdateGenderTypeEvent>
    {
        public UpdateGenderTypeCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<GenderType> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
