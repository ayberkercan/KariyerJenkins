using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Menus.Queries
{
    public class GetMenusQueryRequest : IRequest<ICollection<Menu>>
    {
    }
}
