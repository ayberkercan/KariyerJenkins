using EKSystemApp.Application.Features.Authentication.Commands;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Tools;
using EKSystemApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly RoleManager<AppRole> _roleManager;
        public AuthController(IMediator mediator, RoleManager<AppRole> roleManager)
        {
            _mediator = mediator;
            _roleManager = roleManager;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _mediator.Send(new GetUsersQueryRequest());
            return Ok(result);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetRoles()
        {
            var result = await _mediator.Send(new GetRolesQueryRequest());
            return Ok(result);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(CheckUserQueryRequest request)
        {
            var dto = await _mediator.Send(request);
            if (dto.IsExist)
            {
                return Created("", JwtTokenGenerator.GenerateToken(dto));
            }
            else
            {
                return BadRequest("Kullanıcı adı veya şifre hatali");
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterUserCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }
    }
}
