using AutoMapper;
using EKSystemApp.Application.DTO.AdStatus;
using EKSystemApp.Application.Features.AdStatuses.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.AdStatuses.Handler.List
{
    public class GetAdStatusesQueryHandler : IRequestHandler<GetAdStatuesQueryRequest, ICollection<AdStatusDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<AdStatus> genericRepository;
        public GetAdStatusesQueryHandler(IMapper mapper, IGenericRepository<AdStatus> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<AdStatusDto>> Handle(GetAdStatuesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<AdStatusDto>>(data);
        }
    }
}
