using EKSystemApp.Application.DTO.Products;
using MediatR;

namespace EKSystemApp.Application.Features.Products.Commands
{
    public class CreateProductCommandRequest : IRequest<CreateProductDto>
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
