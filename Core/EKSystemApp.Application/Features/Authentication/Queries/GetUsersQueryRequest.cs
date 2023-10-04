using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Queries
{
    public class GetUsersQueryRequest : IRequest<ICollection<UsersDetailsDto>>
    {
 
    }
}
