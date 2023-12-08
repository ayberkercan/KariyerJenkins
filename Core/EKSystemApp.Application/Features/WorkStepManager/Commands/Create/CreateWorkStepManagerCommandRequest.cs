using EKSystemApp.Application.DTO.WorkStepsManager.Create;
using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Commands.Create
{
    public class CreateWorkStepManagerCommandRequest : IRequest<WorkStepManagerCreateDto>
    {
        public string WorkSteps { get; set; }
        public string WorkStepsTitle { get; set; }
        public string Defination { get; set; }
        public string Image { get; set; }
    }
}
