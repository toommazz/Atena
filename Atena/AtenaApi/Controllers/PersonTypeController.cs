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
    public class PersonTypeController : ApiController<PersonTypeViewModel>
    {
        public PersonTypeController(IMediatorHandler mediator, IPersonTypeService appService) : base(mediator, appService) { }
    }
}
