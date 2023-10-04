using MediatR;

namespace EKSystemApp.Application.Features.Products.Commands
{
    public class UpdateProductCommandRequest : IRequest
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
