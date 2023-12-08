using EKSystemApp.Application.Features.WorkStepManager.Commands.Update;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.WorkStepManager;
using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Handlers.Update
{
    public class UpdateWorkStepManagerCommandHandler : IRequestHandler<UpdateWorkStepManagerCommandRequest>
    {
        private readonly IGenericRepository<WorksStepManager> repository;

        public UpdateWorkStepManagerCommandHandler(IGenericRepository<WorksStepManager> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateWorkStepManagerCommandRequest request, CancellationToken cancellationToken)
        {
            var updateEntity = await this.repository.GetByIdAsync(request.Id);
            if (updateEntity != null)
            {
                updateEntity.WorkStepsTitle = request.WorkStepsTitle;
                updateEntity.WorkSteps = request.WorkSteps;
                updateEntity.Defination = request.Defination;
                updateEntity.Image = request.Image;
                await this.repository.UpdateAsync(updateEntity);
            }
            return Unit.Value;
        }
    }
}
