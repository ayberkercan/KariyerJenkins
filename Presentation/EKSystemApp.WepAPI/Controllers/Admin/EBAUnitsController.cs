using EKSystemApp.Application.Features.EBA.EbaUnits.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class EBAUnitsController : Controller
    {
        private readonly IMediator mediator;

        public EBAUnitsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAUnits()
        {
            return Ok(await this.mediator.Send(new GetEbaUnitsQueryRequest()));
        }
    }
}
