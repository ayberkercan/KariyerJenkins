using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Commands.Update
{
    public class UpdateWorkStepManagerCommandRequest : IRequest
    {
        public Guid Id { get; set; }
        public string WorkSteps { get; set; }
        public string WorkStepsTitle { get; set; }
        public string Defination { get; set; }
        public string Image { get; set; }
    }
}
