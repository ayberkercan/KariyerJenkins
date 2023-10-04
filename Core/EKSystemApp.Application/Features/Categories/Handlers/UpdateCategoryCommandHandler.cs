using EKSystemApp.Application.Features.Categories.Commands;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Categories.Handlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest>
    {
        private readonly IGenericRepository<Category> repository;

        public UpdateCategoryCommandHandler(IGenericRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var updateEntity = await this.repository.GetByIdAsync(request.Id);
            if (updateEntity != null)
            {
                updateEntity.Defination = request.Defination;
                await this.repository.UpdateAsync(updateEntity);
            }
            return Unit.Value;
        }
    }
}
