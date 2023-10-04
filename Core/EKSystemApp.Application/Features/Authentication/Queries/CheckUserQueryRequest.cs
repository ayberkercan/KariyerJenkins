using EKSystemApp.Application.DTO.Jwt;
using MediatR;
using System.Security.Claims;

namespace EKSystemApp.Application.Features.Authentication.Queries
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;

    }
}
