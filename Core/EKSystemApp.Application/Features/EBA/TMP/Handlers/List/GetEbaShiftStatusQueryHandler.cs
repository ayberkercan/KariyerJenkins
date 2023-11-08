using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaShiftStatusQueryHandler : IRequestHandler<GetEbaShiftStatusQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<ShiftStatus> genericRepository;
        private readonly IMapper mapper;

        public GetEbaShiftStatusQueryHandler(IEbaGenericRepository<ShiftStatus> genericRepository, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaShiftStatusQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.genericRepository.GetAllAsync();
            var result = this.mapper.Map<List<EbaStrKvpDto>>(data);
            return this.mapper.Map<ICollection<EbaStrKvpDto>>(result);
        }
    }
}
