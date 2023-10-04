using AutoMapper;
using EKSystemApp.Application.DTO.Authorization;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Mappings.AppUserMap
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            this.CreateMap<AppUser, CreatedUserDto>().ReverseMap();
            this.CreateMap<AppUser, UserListDto>().ReverseMap();
            this.CreateMap<UserListDto, UsersDetailsDto>().ReverseMap();
        }
    }
}
