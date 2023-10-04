using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.Role;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Mappings.AppRoleMAp
{
    public class AppRoleProfile : Profile
    {
        public AppRoleProfile()
        {
            this.CreateMap<AppRole, AppRoleListDto>().ReverseMap();
        }
    }
}
