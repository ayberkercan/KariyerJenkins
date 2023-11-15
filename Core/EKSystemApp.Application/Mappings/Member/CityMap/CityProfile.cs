using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Domain.Entities.Member.Cities;

namespace EKSystemApp.Application.Mappings.Member.CityMap
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<ST_Cities, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ISIM));

            CreateMap<ST_Cities, CityTreeDto>()
                .ForMember(dest => dest.Upkey, opt => opt.MapFrom(src => src.IL_ID))
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ISIM));
        }
    }
}
