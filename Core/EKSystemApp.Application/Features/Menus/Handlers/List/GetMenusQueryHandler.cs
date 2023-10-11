using AutoMapper;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Application.DTO.Products;
using EKSystemApp.Application.Features.Menus.Queries;
using EKSystemApp.Application.Features.Products.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Menus.Handlers.List
{
    public class GetMenusQueryHandler : IRequestHandler<GetMenusQueryRequest, ICollection<MenuListDto>>
    {
        private readonly IGenericRepository<Menu> repository;
        private readonly IMapper _mapper;
        public GetMenusQueryHandler(IGenericRepository<Menu> repository, IMapper mapper)
        {
            this.repository = repository;
            _mapper = mapper;
        }
        public async Task<ICollection<MenuListDto>> Handle(GetMenusQueryRequest request, CancellationToken cancellationToken)
        {
            var menuList = await this.repository.GetAllAsync();
            return this._mapper.Map<ICollection<MenuListDto>>(menuList);
        }
    }
}
