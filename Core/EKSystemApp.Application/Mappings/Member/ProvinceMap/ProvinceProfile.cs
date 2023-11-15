using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Domain.Entities.Member.Provinces;

namespace EKSystemApp.Application.Mappings.Member.ProvinceMap
{
    public class ProvinceProfile : Profile
    {
        public ProvinceProfile()
        {
            CreateMap<ST_Provinces, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.PLAKA))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ISIM));

            CreateMap<ST_Provinces, ProvinceTreeDto>()
                .ForMember(dest => dest.Upkey, opt => opt.MapFrom(src => 220))
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.PLAKA))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ISIM));
        }
    }
}
