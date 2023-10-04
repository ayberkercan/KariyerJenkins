using AutoMapper;
using EKSystemApp.Application.DTO.Categories;
using EKSystemApp.Application.Features.Categories.Commands;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Categories.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreatedCategoryDto>
    //geriye değer döneceği zaman dto'yu da  ekleriz
    {
        private readonly IGenericRepository<Category> repository;
        private readonly IMapper mapper;
        public CreateCategoryCommandHandler(IGenericRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CreatedCategoryDto> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = new Category { Defination = request.Defination };
            var result = await this.repository.CreateAsync(category);
            return this.mapper.Map<CreatedCategoryDto>(result);
        }
    }
}
