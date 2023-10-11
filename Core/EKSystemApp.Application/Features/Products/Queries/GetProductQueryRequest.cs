using EKSystemApp.Application.DTO.Products.List;
using MediatR;

namespace EKSystemApp.Application.Features.Products.Queries
{
    public class GetProductQueryRequest : IRequest<ProductListDto>
    {
        public Guid Id { get; set; }
        public GetProductQueryRequest(Guid id)
        {
            Id = id;
        }
    }
}
