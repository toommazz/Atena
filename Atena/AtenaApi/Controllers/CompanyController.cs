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
    public class CompanyController : ApiController<CompanyViewModel>
    {
        public CompanyController(
            ICompanyService service,
            IMediatorHandler mediator) : base(mediator, service) { }
    }
}
