using EKSystemApp.Application.DTO.WorkStepsManager.List;
using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Queries.List
{
    public class WorkStepManagerQueryRequest : IRequest<WorkStepManagerListDto>
    {
        public Guid Id { get; set; }
        public WorkStepManagerQueryRequest(Guid id)
        {
            Id = id;
        }
    }
}
