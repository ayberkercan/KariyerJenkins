using EKSystemApp.Application.DTO.Authorization;
using EKSystemApp.Application.DTO.Company;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Commands
{
    public class RegisterUserCommandRequest : IRequest<CreatedUserDto>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Registry { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Guid RoleId { get; set; }
        public ICollection<Object> Companies { get; set; }
        public ICollection<Object> Menues { get; set; }
    }
}
