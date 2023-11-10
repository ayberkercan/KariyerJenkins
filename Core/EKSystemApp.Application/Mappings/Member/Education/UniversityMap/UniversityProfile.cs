using AutoMapper;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Education.Universities;
using EKSystemApp.Application.DTO.Member.Education.UniversitiesTree;
using EKSystemApp.Application.DTO.Member.Provinces;
using EKSystemApp.Domain.Entities.Member.Education.Universities;
using EKSystemApp.Domain.Entities.Member.Provinces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.Member.Education.UniversityMap
{
    public class UniversityProfile : Profile
    {
        public UniversityProfile()
        {
            CreateMap<ST_Universities, ST_UniversitiesDto>().ReverseMap();

            CreateMap<ST_Universities, UniversityTreeDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Key))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
        }
    }
}
