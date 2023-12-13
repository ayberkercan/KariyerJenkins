using AutoMapper;
using EKSystemApp.Application.DTO.Blog.List;
using EKSystemApp.Application.DTO.Categories.List;
using EKSystemApp.Application.Features.BlogHeadline.Queries.List;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Blog;
using MediatR;

namespace EKSystemApp.Application.Features.BlogHeadline.Handlers.List
{
    public class ListBlogHeadlineManagerCommandHandler : IRequestHandler<GetAllBlogHeadlineManagersQueryRequest, ICollection<BlogHeadlineDto>>
    {
        private readonly IGenericRepository<BlogHeadlineManager> repository;
        private readonly IMapper mapper;

        public ListBlogHeadlineManagerCommandHandler(IGenericRepository<BlogHeadlineManager> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ICollection<BlogHeadlineDto>> Handle(GetAllBlogHeadlineManagersQueryRequest request, CancellationToken cancellationToken)
        {
            var blogheadline = await this.repository.GetAllAsync();
            return this.mapper.Map<ICollection<BlogHeadlineDto>>(blogheadline);
        }
    }
}
