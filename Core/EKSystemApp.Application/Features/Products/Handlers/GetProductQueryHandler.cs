using AutoMapper;
using EKSystemApp.Application.DTO.Products.List;
using EKSystemApp.Application.Features.Products.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Products.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest, ProductListDto>
    {
        private readonly IGenericRepository<Product> repository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IGenericRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductListDto> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return _mapper.Map<ProductListDto>(data);
        }
    }
}
