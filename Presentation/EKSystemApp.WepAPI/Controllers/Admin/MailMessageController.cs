using EKSystemApp.Application.Features.MailMessage.Commands.Create;
using EKSystemApp.Application.Features.MailMessage.Commands.Update;
using EKSystemApp.Application.Features.MailMessage.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailMessageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MailMessageController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetMailMessageQueryRequest());
            return Ok(result);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateMailMessageCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateMailMessageCommandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request);
        }
    }
}
