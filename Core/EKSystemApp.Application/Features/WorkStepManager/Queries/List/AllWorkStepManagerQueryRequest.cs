using EKSystemApp.Application.DTO.WorkStepsManager.List;
using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Queries.List
{
    public class AllWorkStepManagerQueryRequest : IRequest<ICollection<WorkStepManagerListDto>>
    {
    }
}
