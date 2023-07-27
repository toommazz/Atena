using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Service.Controller;
using Atena.Service.Interfaces;
using Atena.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AtenaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class PeopleController : ApiController<PeopleViewModel>
    {
        public PeopleController(IMediatorHandler mediator, IPeopleService appService) : base(mediator, appService) { }
    }
}
