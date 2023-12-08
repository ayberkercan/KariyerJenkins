using EKSystemApp.Application.Features.WorkStepManager.Commands.Create;
using EKSystemApp.Application.Features.WorkStepManager.Commands.Delete;
using EKSystemApp.Application.Features.WorkStepManager.Commands.Update;
using EKSystemApp.Application.Features.WorkStepManager.Handlers.Delete;
using EKSystemApp.Application.Features.WorkStepManager.Handlers.List;
using EKSystemApp.Application.Features.WorkStepManager.Queries.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Npgsql.Internal.TypeHandlers.DateTimeHandlers;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkStepManagerController : ControllerBase
    {
        private readonly IMediator mediator;

        public WorkStepManagerController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> Get()
        {
            return Ok(await this.mediator.Send(new AllWorkStepManagerQueryRequest()));
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await this.mediator.Send(new WorkStepManagerQueryRequest(id)));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Create(CreateWorkStepManagerCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> Update(UpdateWorkStepManagerCommandRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await this.mediator.Send(new RemoveWorkStepManageerCommandRequest(id)));
        }
    }
}
