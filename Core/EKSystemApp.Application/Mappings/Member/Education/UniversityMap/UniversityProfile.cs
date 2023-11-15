using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Member.Education.UniversitiesTree;
using EKSystemApp.Domain.Entities.Member.Education.Universities;

namespace EKSystemApp.Application.Mappings.Member.Education.UniversityMap
{
    public class UniversityProfile : Profile
    {
        public UniversityProfile()
        {
            CreateMap<ST_Universities, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.TANIM.Split('-', StringSplitOptions.None)[0].Trim()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM.Split('-', StringSplitOptions.None)[1].Trim()));

            CreateMap<ST_Universities, UniversityTreeDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.TANIM.Split('-', StringSplitOptions.None)[0].Trim()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM.Split('-', StringSplitOptions.None)[1].Trim()));
        }
    }
}
