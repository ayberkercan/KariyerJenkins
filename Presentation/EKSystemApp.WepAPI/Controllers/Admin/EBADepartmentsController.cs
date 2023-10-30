using EKSystemApp.Application.Features.EBA.EbaDepartments.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class EBADepartmentsController : ControllerBase
    {
        private readonly IMediator mediator;

        public EBADepartmentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBADepartment()
        {
            return Ok(await this.mediator.Send(new GetEBADepartmentQueryRequest()));
        }
    }
}

