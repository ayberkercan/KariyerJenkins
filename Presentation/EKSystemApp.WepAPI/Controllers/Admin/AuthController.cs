using EKSystemApp.Application.Features.Authentication.Commands.Register;
using EKSystemApp.Application.Features.Authentication.Commands.Remove;
using EKSystemApp.Application.Features.Authentication.Commands.Update;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
using EKSystemApp.Application.Tools;
using EKSystemApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static EKSystemApp.Domain.PermissonList.Permissions;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IElasticSearchService<AppUser> elasticSearchService;
        public AuthController(IMediator mediator, IElasticSearchService<AppUser> elasticSearchService)
        {
            _mediator = mediator;
            this.elasticSearchService = elasticSearchService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetUsers()
        {
            //var result = await _mediator.Send(new GetUsersQueryRequest());
            var result = await this.elasticSearchService.GetDocuments("users");
            return Ok(result);
        }
        [HttpGet("[action]/{role}/{organization}")]
        public async Task<IActionResult> GetUsersById(string role, string organization)
        {
            var result = await _mediator.Send(new GetAllUsersInTableViewQueryRequest(role, organization));
            return Ok(result);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetRoles()
        {
            var result = await _mediator.Send(new GetRolesQueryRequest());
            return Ok(result);
        }
        [HttpGet("[action]/{roleName}")]
        public async Task<IActionResult> GetRolesByRoleName(string roleName)
        {
            var result = await _mediator.Send(new GetRolesByRoleNameQueryRequest(roleName));
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _mediator.Send(request);
            return Created("", result);
        }
        [HttpPut("[action]/{id}")]
        public async Task<IActionResult> Update(UpdateUserCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }
        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> UserRemove(Guid id)
        {
            return Ok(await _mediator.Send(new RemoveUserCommandRequest(id)));
        }

    }
}
