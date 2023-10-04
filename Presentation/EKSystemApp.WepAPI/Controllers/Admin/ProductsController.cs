using EKSystemApp.Application.Features.Products.Commands;
using EKSystemApp.Application.Features.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Authorize(Roles = "SystemAdministrators")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetProductsQueryRequest()));
        }
        [Authorize(Policy = "ProductPolicy")]

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllById(Guid id)
        {
            return Ok(await _mediator.Send(new GetProductQueryRequest(id)));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            return Ok(await _mediator.Send(new RemoveProductCommandRequest(id)));
        }
    }
}

