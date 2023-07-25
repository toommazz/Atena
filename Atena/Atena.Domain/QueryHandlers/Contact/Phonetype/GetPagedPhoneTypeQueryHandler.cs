﻿using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedPhoneTypeQueryHandler : MediatorQueryHandler<GetPagedPhoneTypeQuery, PagedList<PhoneType>>
    {
        private readonly IPhoneTypeRepository _repository;

        public GetPagedPhoneTypeQueryHandler(
            IPhoneTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<PhoneType>> AfterValidation(GetPagedPhoneTypeQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, request.Filter);
        }
    }
}