using EKSystemApp.Application.DTO.Menus.List;
using MediatR;

namespace EKSystemApp.Application.Features.Menus.Queries
{
    public class GetMenuQueryRequest : IRequest<ICollection<MenuListDto>>
    {
        public Guid Id { get; set; }
        public GetMenuQueryRequest(Guid id)
        {
            Id = id;
        }
    }
}
