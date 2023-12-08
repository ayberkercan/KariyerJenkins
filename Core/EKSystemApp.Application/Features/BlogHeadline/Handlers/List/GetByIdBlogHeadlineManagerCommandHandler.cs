using AutoMapper;
using EKSystemApp.Application.DTO.Blog.List;
using EKSystemApp.Application.Features.BlogHeadline.Queries.List;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Blog;
using MediatR;

namespace EKSystemApp.Application.Features.BlogHeadline.Handlers.List
{
    public class GetByIdBlogHeadlineManagerCommandHandler : IRequestHandler<GetByIdBlogHeadlineManagerQueryRequest, BlogHeadlineDto>
    {
        private readonly IGenericRepository<BlogHeadlineManager> repository;
        private readonly IMapper mapper;

        public GetByIdBlogHeadlineManagerCommandHandler(IGenericRepository<BlogHeadlineManager> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<BlogHeadlineDto> Handle(GetByIdBlogHeadlineManagerQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(p => p.Id == request.Id);
            return this.mapper.Map<BlogHeadlineDto>(data);
        }
    }
}
