using MediatR;

namespace EKSystemApp.Application.Features.BlogHeadline.Commands.Remove
{
    public class RemoveBlogHeadlineManagerCommandRequest : IRequest
    {
        public Guid Id { get; set; }
        public RemoveBlogHeadlineManagerCommandRequest(Guid id)
        {
            Id = id;
        }
    }
}
