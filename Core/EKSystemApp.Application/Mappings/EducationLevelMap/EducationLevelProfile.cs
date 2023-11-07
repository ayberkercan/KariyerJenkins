using AutoMapper;
using EKSystemApp.Application.DTO.EducationLevel;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.EducationLevelMap
{
    public class EducationLevelProfile:Profile
    {
        public EducationLevelProfile()
        {
            this.CreateMap<EducationLevel, EducationLevelDto>().ReverseMap();
        }
    }
}
