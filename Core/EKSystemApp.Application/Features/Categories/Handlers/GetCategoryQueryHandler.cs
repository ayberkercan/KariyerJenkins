using AutoMapper;
using EKSystemApp.Application.DTO.Categories.List;
using EKSystemApp.Application.Features.Categories.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Categories.Handlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, CategoriesListDto>
    {
        private readonly IGenericRepository<Category> repository;
        private readonly IMapper mapper;

        public GetCategoryQueryHandler(IGenericRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CategoriesListDto> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<CategoriesListDto>(data);
        }
    }
}
