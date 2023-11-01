using EKSystemApp.Application.Features.Menus.Queries;
using EKSystemApp.Application.Features.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenuesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllMenu()
        {
            return Ok(await _mediator.Send(new GetMenusQueryRequest()));
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetMenuToUserById(Guid id)
        {
            return Ok(await _mediator.Send(new GetMenuQueryRequest(id)));

        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetUserRoleAndMenuListById(Guid id)
        {
            return Ok(await _mediator.Send(new GetMenuQueryRequest(id)));

        }
    }
}
