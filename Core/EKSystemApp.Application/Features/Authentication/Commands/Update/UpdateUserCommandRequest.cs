using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Commands.Update
{
    public class UpdateUserCommandRequest : IRequest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Registry { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Guid RoleId { get; set; }
        public ICollection<AppUserCompany> AppUserCompanies{ get; set; }
        public ICollection<AppUserMenu> AppUserMenus{ get; set; }
    }
}
