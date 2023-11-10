using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using EKSystemApp.Application.DTO.Member.Cities;
using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Provinces;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.eBA.ForeignLanguages;
using EKSystemApp.Domain.Entities.eBA.GeneralSkills;
using EKSystemApp.Domain.Entities.Member.Cities;
using EKSystemApp.Domain.Entities.Member.Countries;
using EKSystemApp.Domain.Entities.Member.Provinces;

namespace EKSystemApp.Application.Mappings.Member.ProvinceMap
{
    public class ProvinceProfile : Profile
    {
        public ProvinceProfile()
        {
            CreateMap<ST_Provinces, ST_ProvincesDto>().ReverseMap();

            CreateMap<ST_Provinces, ProvinceTreeDto>()
                .ForMember(dest => dest.Upkey, opt => opt.MapFrom(src => src.UpKey))
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Key))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
        }
    }
}
