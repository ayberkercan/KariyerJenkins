using AutoMapper;
using EKSystemApp.Application.DTO.TaskType;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Application.Mappings.TasksTypes
{
    public class TaskTypeProfile : Profile
    {
        public TaskTypeProfile()
        {
            this.CreateMap<TaskType, TaskTypeDto>().ReverseMap();
        }
    }
}
