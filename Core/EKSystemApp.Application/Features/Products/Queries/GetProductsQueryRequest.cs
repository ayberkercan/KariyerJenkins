using EKSystemApp.Application.DTO.Products.List;
using MediatR;

namespace EKSystemApp.Application.Features.Products.Queries
{
    public class GetProductsQueryRequest : IRequest<ICollection<ProductListDto>>
    {

    }
}
