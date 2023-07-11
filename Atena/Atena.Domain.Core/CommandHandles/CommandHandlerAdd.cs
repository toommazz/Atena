using Atena.Domain.Core.Events;
using Atena.Domain.Core.Extensions;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Model;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Core.Tools;
using AutoMapper;

namespace Atena.Domain.Core.CommandHandles
{
    public abstract class CommandHandlerAdd<TCommand, TEntity, Event> : MediatorCommandHandler<TCommand>
        where TCommand : Command
        where TEntity : Entity
        where Event : EventCore<TEntity>
    {
        protected IMapper _mapper;

        private readonly IRepository<TEntity> _repository;

        public CommandHandlerAdd(IMediatorHandler mediator, IMapper mapper, IRepository<TEntity> repository)
            : base(mediator)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public override async Task AfterValidation(TCommand request)
        {
            var entity = _mapper.Map<TEntity>(request);

            var query = RepositoryExtension.LambdaInsertGeneration(entity);

            if (query != null)
            {

                var registered = await _repository.GetOneAsync(query);

                if (registered != null)
                {
                    var type = entity.GetType();

                    var properties = type.GetProperties();

                    var ListProperties = properties.Where(c => c.GetCustomAttributes(false).Any(
                        a => a.GetType() == typeof(PropertyValidationAttribute
                        ))).ToList();

                    string message = $"O objeto {entity.GetType().Name} com o(s) valores: ";

                    for (int i = 0; i < ListProperties.Count(); i++)
                    {
                        if (ListProperties[i].GetValue(entity, null).ToString() ==
                            ListProperties[i].GetValue(registered, null).ToString())
                        {
                            message += $"{ListProperties[i].Name}: {ListProperties[i].GetValue(entity, null)}; ";
                        }
                    }

                    NotifyError(message);
                    return;
                }
            }

            await _repository.AddAsync(entity);

            if(!HasNotification())
            {
                await _mediator.RaiseEvent(InstanceCreator.Create<TEntity, Event>(entity) as Event);
            }
            else
            {
                NotifyError("Commit", "Falha na gravação dos dados!");
            }
        }
    }
}
