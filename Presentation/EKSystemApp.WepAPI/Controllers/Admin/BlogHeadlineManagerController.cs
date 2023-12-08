using EKSystemApp.Application.Features.BlogHeadline.Commands.Create;
using EKSystemApp.Application.Features.BlogHeadline.Commands.Remove;
using EKSystemApp.Application.Features.BlogHeadline.Commands.Update;
using EKSystemApp.Application.Features.BlogHeadline.Queries.List;
using MediatR;
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
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var result = await this.mediator.Send(new GetAllBlogHeadlineManagersQueryRequest());
            return Ok(result);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateBlogHandlineCommandRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update(UpdateBlogHeadlineManagerCommandRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> Remove(Guid id)
        {
            return Ok(await this.mediator.Send(new RemoveBlogHeadlineManagerCommandRequest(id)));

        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await this.mediator.Send(new GetByIdBlogHeadlineManagerQueryRequest(id)));
        }
    }
}
