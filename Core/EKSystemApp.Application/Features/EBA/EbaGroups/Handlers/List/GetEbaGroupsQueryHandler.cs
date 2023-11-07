using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaGroup;
using EKSystemApp.Application.Features.EBA.EbaGroups.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.EbaGroups.Handlers.List
{
    public class GetEbaGroupsQueryHandler : IRequestHandler<GetEbaGroupsQueryRequest, ICollection<EbaGroupDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<EbaGroup> genericRepository;

        public GetEbaGroupsQueryHandler(IMapper mapper, IGenericRepository<EbaGroup> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<EbaGroupDto>> Handle(GetEbaGroupsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<EbaGroupDto>>(data);
        }
    }
}
