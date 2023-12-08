using EKSystemApp.Application.DTO.Blog.List;
using MediatR;

namespace EKSystemApp.Application.Features.BlogHeadline.Queries.List
{
    public class GetAllBlogHeadlineManagersQueryRequest : IRequest<ICollection<BlogHeadlineDto>>
    {

    }
}
