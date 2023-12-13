using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Commands.Delete
{
    public class RemoveWorkStepManageerCommandRequest : IRequest
    {
        public Guid Id { get; set; }
        public RemoveWorkStepManageerCommandRequest(Guid id)
        {
            Id = id;
        }
    }
}
