using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaStaffTypeQueryHandler : IRequestHandler<GetEbaStaffTypeQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaGenericRepository<StaffType> genericRepository;
        private readonly IMapper mapper;

        public GetEbaStaffTypeQueryHandler(IEbaGenericRepository<StaffType> genericRepository, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaStaffTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.genericRepository.GetAllAsync();
            var result = this.mapper.Map<List<EbaKvpDto>>(data).OrderBy(x => x.Key).ToList();
            return this.mapper.Map<ICollection<EbaKvpDto>>(result);
        }
    }
}
