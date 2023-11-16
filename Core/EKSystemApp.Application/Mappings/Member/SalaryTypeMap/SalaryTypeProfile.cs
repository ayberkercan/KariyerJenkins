using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Domain.Entities.Member.Currency;
using EKSystemApp.Domain.Entities.Member.SalaryType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.Member.SalaryTypeMap
{
    public class SalaryTypeProfile : Profile
    {
        public SalaryTypeProfile()
        {
            CreateMap<SalaryTypes, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));
        }
    }
}
