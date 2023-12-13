using AutoMapper;
using EKSystemApp.Application.DTO.Blog.Create;
using EKSystemApp.Application.Features.BlogHeadline.Commands.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Blog;
using MediatR;

namespace EKSystemApp.Application.Features.BlogHeadline.Handlers.Create
{
    public class CreateBlogHandlineQueryCommandHandler : IRequestHandler<CreateBlogHandlineCommandRequest, BlogHeadlineCreateDto>
    {
        private readonly IGenericRepository<BlogHeadlineManager> repository;
        private readonly IMapper mapper;

        public CreateBlogHandlineQueryCommandHandler(IGenericRepository<BlogHeadlineManager> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<BlogHeadlineCreateDto> Handle(CreateBlogHandlineCommandRequest request, CancellationToken cancellationToken)
        {
            var blogHandline = new BlogHeadlineManager
            {
                BlogTitle = request.BlogTitle,
                BlogPublicStatu = request.BlogPublicStatu,
                Description = request.Description,
                HeadlinePublicStatu = request.HeadlinePublicStatu,
                Image = request.Image,
                LinkHeadline = request.LinkHeadline,
                PublicationEndDate = request.PublicationEndDate,
                PublicationPage = request.PublicationPage,
                AppUserId = request.AppUserId,
                AppUser = request.AppUser
            };
            var result = await this.repository.CreateAsync(blogHandline);
            return this.mapper.Map<BlogHeadlineCreateDto>(result);
        }
    }
}
