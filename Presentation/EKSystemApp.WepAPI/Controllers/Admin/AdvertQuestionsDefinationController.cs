using Azure.Core;
using EKSystemApp.Application.Features.AdQuestions.Command.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertQuestionsDefinationController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AdvertQuestionsDefinationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[HttpGet("[action]")]
        //public async Task<IActionResult> GetAllCompany()
        //{
        //    var data = await _mediator.Send(new GetCompanyQueryRequest());
        //    return Ok(data);
        //}
        [HttpPost]
        public async Task<IActionResult> Create(AdvertQuestionsDefinationRequest request)
        {
            await _mediator.Send(request);
            return Created("", request);
        }
    }
}
