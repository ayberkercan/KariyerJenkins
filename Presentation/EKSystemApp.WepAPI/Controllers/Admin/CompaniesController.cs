using EKSystemApp.Application.Features.Companies.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompaniesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCompany()
        {
            var data = await _mediator.Send(new GetCompanyQueryRequest());
            return Ok(data);
        }
        [HttpGet("[action]/{organization}")]
        public async Task<IActionResult> GetUserOrganizations(string organization)
        {
            var data = await _mediator.Send(new GetUserCompanyByOrganizationNameQueryRequest(organization));
            return Ok(data);
        }
    }
}
