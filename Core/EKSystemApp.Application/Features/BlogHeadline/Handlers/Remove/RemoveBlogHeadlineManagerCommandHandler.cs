using EKSystemApp.Application.Features.BlogHeadline.Commands.Remove;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Blog;
using MediatR;

namespace EKSystemApp.Application.Features.BlogHeadline.Handlers.Remove
{
    public class RemoveBlogHeadlineManagerCommandHandler : IRequestHandler<RemoveBlogHeadlineManagerCommandRequest>
    {
        private readonly IGenericRepository<BlogHeadlineManager> repository;

        public RemoveBlogHeadlineManagerCommandHandler(IGenericRepository<BlogHeadlineManager> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RemoveBlogHeadlineManagerCommandRequest request, CancellationToken cancellationToken)
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
