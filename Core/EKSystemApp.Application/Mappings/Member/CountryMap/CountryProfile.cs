using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Domain.Entities.Member.Countries;

namespace EKSystemApp.Application.Mappings.Member.CountryMap
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<ST_Countries, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.TANIM.Split("-", StringSplitOptions.None)[0].Trim()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM.Split("-", StringSplitOptions.None)[1].Trim()));

            CreateMap<ST_Countries, CountryTreeDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.TANIM.Split("-", StringSplitOptions.None)[0].Trim()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM.Split("-", StringSplitOptions.None)[1].Trim()));
        }
    }
}
