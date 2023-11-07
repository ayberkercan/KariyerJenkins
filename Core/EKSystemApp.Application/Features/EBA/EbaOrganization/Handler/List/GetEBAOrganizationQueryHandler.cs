using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaOrganization;
using EKSystemApp.Application.Features.EBA.EbaOrganization.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.EbaOrganization.Handler.List
{
    public class GetEbaOrganizationQueryHandler : IRequestHandler<GetEbaOrganizationQueryRequest, ICollection<EbaOrganizationDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<Organization> genericRepository;

        public GetEbaOrganizationQueryHandler(IMapper mapper, IGenericRepository<Organization> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<EbaOrganizationDto>> Handle(GetEbaOrganizationQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<EbaOrganizationDto>>(data);
        }
    }
}
