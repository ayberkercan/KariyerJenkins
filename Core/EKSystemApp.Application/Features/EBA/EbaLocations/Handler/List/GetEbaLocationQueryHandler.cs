using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaLocation;
using EKSystemApp.Application.Features.EBA.EBACompanies.Queries;
using EKSystemApp.Application.Features.EBA.EbaLocations.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.EbaLocations.Handler.List
{
    public class GetEbaLocationQueryHandler : IRequestHandler<GetEbaLocationsQueryRequest, ICollection<EbaLocationDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<Location> genericRepository;
        public GetEbaLocationQueryHandler(IMapper mapper, IGenericRepository<Location> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<EbaLocationDto>> Handle(GetEbaLocationsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<EbaLocationDto>>(data);
        }
    }
}
