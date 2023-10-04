using EKSystemApp.Application.DTO.Products;
using MediatR;

namespace EKSystemApp.Application.Features.Products.Queries
{
    public class GetProductsQueryRequest : IRequest<ICollection<ProductListDto>>
    {

    }
}
