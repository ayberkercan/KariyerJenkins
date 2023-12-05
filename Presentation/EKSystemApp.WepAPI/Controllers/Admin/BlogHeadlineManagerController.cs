using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Features.BlogHeadline.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogHeadlineManagerController : ControllerBase
    {
        private readonly IMediator mediator;

        public BlogHeadlineManagerController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateBlogHandlineCommandRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
    }
}
