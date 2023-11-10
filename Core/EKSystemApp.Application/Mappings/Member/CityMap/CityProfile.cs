using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using EKSystemApp.Application.DTO.Member.Cities;
using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.eBA.ForeignLanguages;
using EKSystemApp.Domain.Entities.eBA.GeneralSkills;
using EKSystemApp.Domain.Entities.Member.Cities;
using EKSystemApp.Domain.Entities.Member.Countries;

namespace EKSystemApp.Application.Mappings.Member.CityMap
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<ST_Cities, ST_CitiesDto>().ReverseMap();

            CreateMap<ST_Cities, CityTreeDto>()
                .ForMember(dest => dest.Upkey, opt => opt.MapFrom(src => src.UpKey))
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Key))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
        }
    }
}
