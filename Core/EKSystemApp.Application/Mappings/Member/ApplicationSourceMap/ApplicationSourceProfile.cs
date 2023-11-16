using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Domain.Entities.Member.ApplicationSource;
using EKSystemApp.Domain.Entities.Member.Education.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.Member.ApplicationSourceMap
{
    public class ApplicationSourceProfile : Profile
    {
        public ApplicationSourceProfile()
        {
            CreateMap<M_ApplicationSources, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ApplicationSourceCode))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ApplicationSourceName));
        }
    }
}
