using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EBACompany;
using EKSystemApp.Application.Features.EBA.EBACompanies.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.EBACompanies.Handlers.List
{
    public class GetEBACompaniesQueryHandler : IRequestHandler<GetEBACompaniesQueryRequest, ICollection<EbaCompanyDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<EbaCompany> genericRepository;

        public GetEBACompaniesQueryHandler(IMapper mapper, IGenericRepository<EbaCompany> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<EbaCompanyDto>> Handle(GetEBACompaniesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<EbaCompanyDto>>(data);
        }
    }
}
