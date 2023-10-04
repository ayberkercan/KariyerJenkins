using EKSystemApp.Application.DTO.Categories;
using MediatR;

namespace EKSystemApp.Application.Features.Categories.Queries
{
    public class GetCategoryQueryRequest : IRequest<CategoriesListDto>
    {
        public Guid Id { get; set; }
        public GetCategoryQueryRequest(Guid id)
        {
            Id = id;
        }
    }
}
