using AutoMapper;
using EKSystemApp.Application.DTO.Member.Education.Departments;
using EKSystemApp.Application.DTO.Member.Education.Universities;
using EKSystemApp.Application.DTO.Member.Education.UniversitiesTree;
using EKSystemApp.Domain.Entities.Member.Education.Departments;
using EKSystemApp.Domain.Entities.Member.Education.Universities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.Member.Education.DepartmentMap
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<ST_Departments, ST_DepartmentsDto>().ReverseMap();

            CreateMap<ST_Departments, EducationDepartmentTreeDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Key))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
        }
    }
}
