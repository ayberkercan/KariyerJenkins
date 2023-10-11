using AutoMapper;
using EKSystemApp.Application.DTO.Products.List;
using EKSystemApp.Application.Features.Products.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Products.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQueryRequest, ICollection<ProductListDto>>
    {
        private readonly IGenericRepository<Product> repository;
        private readonly IMapper _mapper;
        public GetProductsQueryHandler(IGenericRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            _mapper = mapper;
        }

        public async Task<ICollection<ProductListDto>> Handle(GetProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var getProducts = await this.repository.GetAllAsync();
            return _mapper.Map<ICollection<ProductListDto>>(getProducts);
        }
    }
}
