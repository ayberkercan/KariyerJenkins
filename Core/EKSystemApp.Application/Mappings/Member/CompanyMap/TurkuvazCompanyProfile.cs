using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Domain.Entities.Member.Education.Departments;
using EKSystemApp.Domain.Entities.Member.TurkuvazCompanies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.Member.CompanyMap
{
    public class TurkuvazCompanyProfile : Profile
    {
        public TurkuvazCompanyProfile()
        {
            CreateMap<M_TurkuvazCompanies, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.CompanyCode))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.CompanyName));
        }
    }
}
