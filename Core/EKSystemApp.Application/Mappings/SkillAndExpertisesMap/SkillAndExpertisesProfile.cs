using AutoMapper;
using EKSystemApp.Application.DTO.SkillAndExpertis;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.SkillAndExpertisesMap
{
    public class SkillAndExpertisesProfile:Profile
    {
        public SkillAndExpertisesProfile()
        {
            CreateMap<SkillAndExpertise, SkillAndExpertisDto>().ReverseMap();
        }
    }
}
