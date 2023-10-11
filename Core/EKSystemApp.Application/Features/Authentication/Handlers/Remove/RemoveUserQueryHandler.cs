using EKSystemApp.Application.Features.Authentication.Commands.Remove;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.RemoveHandlers
{
    public class RemoveUserQueryHandler : IRequestHandler<RemoveUserCommandRequest>
    {
        private readonly IGenericRepository<AppUser> repository;

        public RemoveUserQueryHandler(IGenericRepository<AppUser> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RemoveUserCommandRequest request, CancellationToken cancellationToken)
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
