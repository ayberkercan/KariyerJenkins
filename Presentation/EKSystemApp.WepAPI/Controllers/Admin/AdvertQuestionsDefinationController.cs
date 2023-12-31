﻿using Azure.Core;
using EKSystemApp.Application.Features.AdQuestions.Command.Create;
using EKSystemApp.Application.Features.AdQuestions.Command.Remove;
using EKSystemApp.Application.Features.AdQuestions.Questions;
using EKSystemApp.Application.Features.Categories.Commands;
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
        [HttpGet("[action]")]
        public async Task<IActionResult> Get()
        {
            var data = await _mediator.Send(new GetAdQuestionsQueryRequest());
            return Ok(data);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(AdvertQuestionsDefinationRequest request)
        {
            await _mediator.Send(request);
            return Created("", request);
        }
        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            return Ok(await _mediator.Send(new RemoveAdvertQuestionDefinationRequest(id)));
        }
    }
}