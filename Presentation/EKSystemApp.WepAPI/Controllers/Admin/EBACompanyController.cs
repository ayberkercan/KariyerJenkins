using EKSystemApp.Application.Features.EBA.EBACompanies.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class EBACompanyController : ControllerBase
    {
        private readonly IMediator mediator;

        public EBACompanyController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBACompany()
        {
            return Ok(await this.mediator.Send(new GetEBACompaniesQueryRequest()));
        }
    }
}
