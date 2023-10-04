using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Application.DTO.Authorization.Role;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Queries
{
    public class GetRolesQueryRequest : IRequest<ICollection<AppRoleListDto>>
    {
    }
}
