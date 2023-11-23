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
            this.CreateMap<AdvertCreate, CreateAdvertDto>().ReverseMap();
            this.CreateMap<AdvertCreate, AdvertListDto>().ReverseMap();
            this.CreateMap<string, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src));
            this.CreateMap<int, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ToString()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ToString()));
            this.CreateMap<string, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src));
            this.CreateMap<int, EbaIntKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src));
        }
    }
}
