using AutoMapper;
using EKSystemApp.Application.DTO.Products.Create;
using EKSystemApp.Application.Features.Products.Commands;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Products.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductDto>
    {
        private readonly IGenericRepository<Product> repository;
        private readonly IMapper mapper;

        public CreateProductCommandHandler(IGenericRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CreateProductDto?> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.CreateAsync(new Product
            {
                CategoryId = request.CategoryId,
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock,
            });
            return this.mapper.Map<CreateProductDto>(data);
        }
    }
}
