using AutoMapper;
using EKSystemApp.Application.DTO.MillitaryStatus;
using EKSystemApp.Application.Features.MillitaryStatuses.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.MillitaryStatuses.Handler.List
{
    public class GetMillitaryStatusesQueryHandler : IRequestHandler<GetMillitaryStatusesQueryRequest, ICollection<MillitaryStatusDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<MillitaryStatus> genericRepository;

        public GetMillitaryStatusesQueryHandler(IMapper mapper, IGenericRepository<MillitaryStatus> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<MillitaryStatusDto>> Handle(GetMillitaryStatusesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<MillitaryStatusDto>>(data);
        }
    }
}
