using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Member.Education.UniversitiesTree;
using EKSystemApp.Domain.Entities.Member.Education.Departments;

namespace EKSystemApp.Application.Mappings.Member.Education.DepartmentMap
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<M_EducationDepartments, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.DepartmentCode))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.DepartmentName));
            
            CreateMap<M_EducationDepartments, EducationDepartmentTreeDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.DepartmentCode))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.DepartmentName));
            
            CreateMap<EbaStrKvpDto, EducationDepartmentTreeDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Key))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
        }
    }
}
