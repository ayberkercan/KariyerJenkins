using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EBACompany;
using EKSystemApp.Application.DTO.Eba.EbaGroup;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Application.Mappings.Eba.EbaGroupMap
{
    public class EbaGroupProfile:Profile
    {
        public EbaGroupProfile() 
        {
            CreateMap<EbaGroup, EbaGroupDto>().ReverseMap();
        }
    }
}
