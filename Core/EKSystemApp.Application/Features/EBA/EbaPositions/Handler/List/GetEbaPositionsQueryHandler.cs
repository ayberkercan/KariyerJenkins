using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaPosition;
using EKSystemApp.Application.Features.EBA.EbaPositions.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.EbaPositions.Handler.List
{
    public class GetEbaPositionsQueryHandler : IRequestHandler<GetEbaPositionQueryRequest, ICollection<EbaPositionDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<Position> genericRepository;
        public GetEbaPositionsQueryHandler(IMapper mapper, IGenericRepository<Position> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<EbaPositionDto>> Handle(GetEbaPositionQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<EbaPositionDto>>(data);
        }
    }
}
