using EKSystemApp.Application.DTO.Menus.List;
using MediatR;

namespace EKSystemApp.Application.Features.Menus.Queries
{
    public class GetMenusQueryRequest : IRequest<ICollection<MenuListDto>>
    {
    }
}
