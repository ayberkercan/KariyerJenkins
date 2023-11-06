using EKSystemApp.Application.DTO.Authorization.User.Create;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Commands.Register
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
        public ICollection<object> Companies { get; set; }
        public ICollection<object> Menues { get; set; }
    }
}
