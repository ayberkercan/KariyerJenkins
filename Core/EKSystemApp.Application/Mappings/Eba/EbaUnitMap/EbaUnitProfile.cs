using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaUnit;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Application.Mappings.Eba.EbaUnitMap
{
    public class EbaUnitProfile:Profile
    {
        public EbaUnitProfile()
        {
            CreateMap<EbaUnit, EbaUnitDto>().ReverseMap();
        }
    }
}
