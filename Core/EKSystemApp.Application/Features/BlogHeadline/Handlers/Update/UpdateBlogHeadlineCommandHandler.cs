using EKSystemApp.Application.Features.BlogHeadline.Commands.Update;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Blog;
using MediatR;

namespace EKSystemApp.Application.Features.BlogHeadline.Handlers.Update
{
    public class UpdateBlogHeadlineCommandHandler : IRequestHandler<UpdateBlogHeadlineManagerCommandRequest>
    {
        private readonly IGenericRepository<BlogHeadlineManager> repository;

        public UpdateBlogHeadlineCommandHandler(IGenericRepository<BlogHeadlineManager> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateBlogHeadlineManagerCommandRequest request, CancellationToken cancellationToken)
        {
            var updateEntity = await this.repository.GetByIdAsync(request.Id);
            if (updateEntity != null)
            {
                updateEntity.BlogTitle = request.BlogTitle;
                updateEntity.BlogPublicStatu = request.BlogPublicStatu;
                updateEntity.PublicationPage = request.PublicationPage;
                updateEntity.PublicationEndDate = request.PublicationEndDate;
                updateEntity.AppUserId = request.AppUserId;
                updateEntity.Image = request.Image;
                updateEntity.HeadlinePublicStatu = request.HeadlinePublicStatu;
                updateEntity.Description = request.Description;
                updateEntity.LinkHeadline = request.LinkHeadline;

                await this.repository.UpdateAsync(updateEntity);
            }
            return Unit.Value;
        }
    }
}
