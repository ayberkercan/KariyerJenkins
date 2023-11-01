using AutoMapper;
using EKSystemApp.Application.DTO.WorkType;
using EKSystemApp.Application.Features.WorkTypes.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;
using Nest;

namespace EKSystemApp.Application.Features.WorkTypes.Handler.List
{
    public class GetWorkTypesQueryHandler : IRequestHandler<GetWorkTypesQueryRequest, ICollection<WorkTypeDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<WorkType> genericRepository;

        public GetWorkTypesQueryHandler(IMapper mapper, IGenericRepository<WorkType> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<WorkTypeDto>> Handle(GetWorkTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<WorkTypeDto>>(data);
        }
    }
}
