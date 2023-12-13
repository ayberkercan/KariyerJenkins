using AutoMapper;
using EKSystemApp.Application.DTO.WorkStepsManager.Create;
using EKSystemApp.Application.DTO.WorkStepsManager.List;
using EKSystemApp.Domain.Entities.Admin.WorkStepManager;

namespace EKSystemApp.Application.Mappings.WorkStepsManagerMap
{
    public class WorkStepManagerProfile : Profile
    {
        public WorkStepManagerProfile()
        {
            CreateMap<WorksStepManager, WorkStepManagerCreateDto>().ReverseMap();
            CreateMap<WorksStepManager, WorkStepManagerListDto>().ReverseMap();
        }
    }
}
