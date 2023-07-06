using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Notifications;
using Atena.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Atena.Service.Controller
{
    public abstract class ApiController<TView> : ControllerBase
        where TView : class
    {
        private readonly DomainNotificationHandler _notifications;

        protected IMediatorHandler _mediator { get; }

        private readonly IAppService<TView> _appService;

        protected ApiController(IMediatorHandler mediator, IAppService<TView> appService)
        {
            _notifications = (DomainNotificationHandler)mediator.GetNotificationHandler();
            _mediator = mediator;
            _appService = appService;
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get(int page = 1,
            int size = 20, string orderProperty = "Id", bool orderCrescent = true)
        {
            var result = await _appService.GetPaged(page, size, orderProperty, orderCrescent);
            return Response(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid? id)
        {
            var result = await _appService.Get(id);

            return Response(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TView model)
        {
            await _appService.Save(model);

            return Response(model);
        }

        protected bool IsValidOperation()
        {
            return true;
            //return (!_notifications.HasNotifications());
        }

        protected new IActionResult Response(object result = null)
        {
            if (IsValidOperation())
                return Ok(new SuccessResponse<object>(result));

            return BadRequest(new BadRequestResponse(
                _notifications.GetNotifications().Select(n => n.Value)));
        }

        protected IActionResult ResponseWithError(string error)
        {
            NotifyError(error);

            return Response();
        }

        protected void NotifyError(string code, string message)
        {
            _mediator.RaiseEvent(new DomainNotification(code, message));
        }

        protected void NotifyError(string message) => NotifyError(string.Empty, message);
    }
}
