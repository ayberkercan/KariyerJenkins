using EKSystemApp.Application.DTO.Categories;
using MediatR;

namespace EKSystemApp.Application.Features.Categories.Queries
{
    public class GetCategoriesQueryRequest : IRequest<ICollection<CategoriesListDto>>
    {

    }
}
