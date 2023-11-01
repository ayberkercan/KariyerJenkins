using AutoMapper;
using EKSystemApp.Application.DTO.WorkModel;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.WorkModelMap
{
    public class WorkModelProfile:Profile
    {
        public WorkModelProfile() 
        {
            CreateMap<WorkModel, WorkModelDto>().ReverseMap();
        }
    }
}
