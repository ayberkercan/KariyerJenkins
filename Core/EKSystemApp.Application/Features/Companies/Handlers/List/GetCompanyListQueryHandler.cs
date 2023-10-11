using AutoMapper;
using EKSystemApp.Application.DTO.Company.List;
using EKSystemApp.Application.Features.Companies.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Companies.Handlers.List
{
    public class GetCompanyListQueryHandler : IRequestHandler<GetCompanyQueryRequest, ICollection<CompaniesListDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<Company> genericRepository;
        public GetCompanyListQueryHandler(IMapper mapper, IGenericRepository<Company> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<CompaniesListDto>> Handle(GetCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.genericRepository.GetAllAsync();
            return this.mapper.Map<ICollection<CompaniesListDto>>(data);
        }
    }
}
