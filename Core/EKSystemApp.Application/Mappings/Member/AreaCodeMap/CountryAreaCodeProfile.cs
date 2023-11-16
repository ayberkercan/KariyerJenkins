using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Domain.Entities.Member.AreaCodes;
using EKSystemApp.Domain.Entities.Member.TurkuvazCompanies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.Member.CountryAreaCodeMap
{
    public class CountryAreaCodeProfile : Profile
    {
        public CountryAreaCodeProfile() 
        {
            CreateMap<CountryAreaCodes, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.CountryCode))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.CountryAreaCode));
        }
    }
}
