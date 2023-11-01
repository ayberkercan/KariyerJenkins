using EKSystemApp.Application.DTO.Authorization.Role;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Queries
{
    public class GetRolesQueryRequest : IRequest<ICollection<AppRoleListDto>>
    {
    }
}
