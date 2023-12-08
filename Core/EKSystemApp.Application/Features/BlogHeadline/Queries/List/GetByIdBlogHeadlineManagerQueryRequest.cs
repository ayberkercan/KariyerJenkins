using EKSystemApp.Application.DTO.Blog.List;
using MediatR;

namespace EKSystemApp.Application.Features.BlogHeadline.Queries.List
{
    public class GetByIdBlogHeadlineManagerQueryRequest : IRequest<BlogHeadlineDto>
    {
        public Guid Id { get; set; }
        public GetByIdBlogHeadlineManagerQueryRequest(Guid id)
        {
            Id = id;
        }
    }
}