using AutoMapper;
using EKSystemApp.Application.DTO.Blog.Create;
using EKSystemApp.Application.Features.BlogHeadline.Commands.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Blog;
using MediatR;
using Nest;

namespace EKSystemApp.Application.Features.BlogHeadline.Handlers.Create
{
    public class CreateBlogHandlineQueryHandler : IRequestHandler<CreateBlogHandlineCommandRequest, BlogHeadlineCreateDto>
    {
        private readonly IGenericRepository<BlogHeadlineManager> repository;
        private readonly IMapper mapper;

        public CreateBlogHandlineQueryHandler(IGenericRepository<BlogHeadlineManager> repository, IMapper mapper)
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
                HeadlinePublicStatü = request.HeadlinePublicStatü,
                Image = request.Image,
                LinkHeadline = request.LinkHeadline,
                PublicationEndDate = request.PublicationEndDate,
                PublicationPage = request.PublicationPage
            };
            var result = await this.repository.CreateAsync(blogHandline);
            return this.mapper.Map<BlogHeadlineCreateDto>(result);
        }
    }
}
