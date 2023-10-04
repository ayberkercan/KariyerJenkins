using EKSystemApp.Application.Features.Categories.Commands;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Categories.Handlers
{
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommandRequest>
    {
        private readonly IGenericRepository<Category> repository;

        public RemoveCategoryCommandHandler(IGenericRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RemoveCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await this.repository.GetByIdAsync(request.Id);
            if (deletedEntity != null)
            {
                await this.repository.Remove(deletedEntity);
            }
            return Unit.Value;
        }

    }
}
