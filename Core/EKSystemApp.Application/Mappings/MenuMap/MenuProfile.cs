using AutoMapper;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Mappings.MenuMap
{
    public class MenuProfile : Profile
    {
        public MenuProfile()
        {
            this.CreateMap<Menu, MenuListDto>().ReverseMap();
        }
    }
}
