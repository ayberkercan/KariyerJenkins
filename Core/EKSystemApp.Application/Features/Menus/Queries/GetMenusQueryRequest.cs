using EKSystemApp.Application.DTO.Menus;
using MediatR;

namespace EKSystemApp.Application.Features.Menus.Queries
{
    public class GetMenusQueryRequest : IRequest<ICollection<MenuListDto>>
    {
    }
}
