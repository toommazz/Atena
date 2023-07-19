﻿using Atena.Domain.Commands.People.PersonType;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers.Login
{
    public class UpdatePersonTypeCommandHandler : CommandHandlerUpdate<UpdatePersonTypeCommand, PersonType, UpdatePersonTypeEvent>
    {
        public UpdatePersonTypeCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<PersonType> repository) : base(mediator, mapper, repository)
        {
        }
    }
}