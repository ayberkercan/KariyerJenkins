using EKSystemApp.Application.DTO.Authorization.Role;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Queries
{
    public class GetRolesByRoleNameQueryRequest : IRequest<ICollection<AppRoleListDto>>
    {
        public string roleName { get; set; }
        public GetRolesByRoleNameQueryRequest(string roleName)
        {
            this.roleName = roleName;
        }
    }
}
