using MediatR;

namespace EKSystemApp.Application.Features.Categories.Commands
{
    public class RemoveCategoryCommandRequest : IRequest
    {
        public Guid Id { get; set; }
        public RemoveCategoryCommandRequest(Guid id)
        {
            Id = id;
        }
    }

}
