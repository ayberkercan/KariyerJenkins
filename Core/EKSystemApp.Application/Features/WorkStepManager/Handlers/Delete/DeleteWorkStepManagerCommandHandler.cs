using EKSystemApp.Application.Features.WorkStepManager.Commands.Delete;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.WorkStepManager;
using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Handlers.Delete
{
    public class DeleteWorkStepManagerCommandHandler : IRequestHandler<RemoveWorkStepManageerCommandRequest>
    {
        private readonly IGenericRepository<WorksStepManager> repository;

        public DeleteWorkStepManagerCommandHandler(IGenericRepository<WorksStepManager> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RemoveWorkStepManageerCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteEntity = await this.repository.GetByIdAsync(request.Id);
            if (deleteEntity != null)
            {
                await this.repository.Remove(deleteEntity);
            }
            return Unit.Value;
        }
    }
}
