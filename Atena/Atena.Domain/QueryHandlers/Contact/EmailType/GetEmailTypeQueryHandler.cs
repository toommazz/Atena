﻿using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetEmailTypeQueryHandler : MediatorQueryHandler<GetEmailTypeQuery, EmailType>
    {
        private readonly IEmailTypeRepository _repository;

        public GetEmailTypeQueryHandler(
            IEmailTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<EmailType> AfterValidation(GetEmailTypeQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}