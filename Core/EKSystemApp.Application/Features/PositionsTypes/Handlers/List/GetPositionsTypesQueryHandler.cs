using AutoMapper;
using EKSystemApp.Application.DTO.PositionsTypes;
using EKSystemApp.Application.Features.PositionsTypes.Queries.List;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;

namespace EKSystemApp.Application.Features.PositionsTypes.Handlers.List
{
    public class GetPositionsTypesQueryHandler : IRequestHandler<GetPositionsTypeQueryRequest, ICollection<PositionsTypesDto>>
    {
        private readonly IGenericRepository<PositionType> repository;
        private readonly IMapper mapper;

        public GetPositionsTypesQueryHandler(IGenericRepository<PositionType> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ICollection<PositionsTypesDto>> Handle(GetPositionsTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await repository.GetAllAsync();
            return mapper.Map<ICollection<PositionsTypesDto>>(data);
        }
    }
}
