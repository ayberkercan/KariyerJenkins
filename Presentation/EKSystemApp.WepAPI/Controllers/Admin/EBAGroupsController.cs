using EKSystemApp.Application.Features.EBA.EbaGroups.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class EbaGroupsController : ControllerBase
    {
        private readonly IMediator mediator;

        public EbaGroupsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAGroups()
        {
            return Ok(await this.mediator.Send(new GetEBAGroupsQueryRequest()));
        }
    }
}
