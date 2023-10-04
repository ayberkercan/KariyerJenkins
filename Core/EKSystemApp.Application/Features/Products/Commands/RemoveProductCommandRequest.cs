using MediatR;

namespace EKSystemApp.Application.Features.Products.Commands
{
    public class RemoveProductCommandRequest : IRequest
    {
        public Guid Id { get; set; }
        public RemoveProductCommandRequest(Guid id)
        {
            Id = id;
        }
    }
}
