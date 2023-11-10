using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.eBA.ForeignLanguages;
using EKSystemApp.Domain.Entities.eBA.GeneralSkills;
using EKSystemApp.Domain.Entities.Member.Countries;

namespace EKSystemApp.Application.Mappings.Member.CountryMap
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<ST_Countries, ST_CountriesDto>().ReverseMap();

            CreateMap<ST_Countries, CountryTreeDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Key))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
        }
    }
}
