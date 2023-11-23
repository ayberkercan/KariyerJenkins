using AutoMapper;
using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Application.Mappings.AdvertMap
{
    public class AdvertProfile:Profile
    {
        public AdvertProfile()
        {
            CreateMap<AdvertCreate, CreateAdvertDto>().ReverseMap();
            CreateMap<AdvertCreate, AdvertListDto>().ReverseMap();
            CreateMap<string, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src));
            CreateMap<int, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ToString()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ToString()));
            CreateMap<string, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src));
            CreateMap<int, EbaIntKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src));
        }
    }
}
