using EKSystemApp.Application.DTO.Authorization.User;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Queries
{
    public class GetUsersQueryRequest : IRequest<ICollection<UsersDetailsDto>>
    {
 
    }
}
