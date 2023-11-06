using AutoMapper;
using EKSystemApp.Application.DTO.JobCategory;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.JobCategoriesMap
{
    public class JobCategoriesProfile:Profile
    {
        public JobCategoriesProfile() 
        {
            CreateMap<JobCategory, JobCategoryDto>().ReverseMap();
        }
    }
}
