using EKSystemApp.Application.Features.TasksTypes.Queries.List;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskTypeController : ControllerBase
    {
        private readonly IMediator mediator;

        public TaskTypeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllTasksTypes()
        {
            return Ok(await this.mediator.Send(new GetTasksTypesQueryRequest()));
        }
    }
}
