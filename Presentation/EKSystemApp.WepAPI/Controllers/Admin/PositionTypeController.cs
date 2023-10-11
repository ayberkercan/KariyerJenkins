﻿using EKSystemApp.Application.Features.PositionsTypes.Queries.List;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PositionTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetPositionsTypes()
        {
            return Ok(await _mediator.Send(new GetPositionsQueryRequest()));
        }
    }
}