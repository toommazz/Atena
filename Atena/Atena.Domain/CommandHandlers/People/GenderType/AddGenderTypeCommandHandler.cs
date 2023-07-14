﻿using Atena.Domain.Commands.People.GenderType;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class AddGenderTypeCommandHandler : CommandHandlerAdd<AddGenderTypeCommand, GenderType, AddedGenderTypeEvent>
    {
        public AddGenderTypeCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<GenderType> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
