using EKSystemApp.Application.DTO.Categories.List;
using MediatR;

namespace EKSystemApp.Application.Features.Categories.Queries
{
    public class GetCategoriesQueryRequest : IRequest<ICollection<CategoriesListDto>>
    {

    }
}
