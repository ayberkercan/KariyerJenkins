using AutoMapper;
using EKSystemApp.Application.DTO.Categories.List;
using EKSystemApp.Application.Features.Categories.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Categories.Handlers
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQueryRequest, ICollection<CategoriesListDto>>
    {
        private readonly IGenericRepository<Category> repository;
        private readonly IMapper mapper;

        public GetCategoriesQueryHandler(IGenericRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ICollection<CategoriesListDto>> Handle(GetCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var categories = await this.repository.GetAllAsync();
            return this.mapper.Map<ICollection<CategoriesListDto>>(categories);

        }
    }
}
