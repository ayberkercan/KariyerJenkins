using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Members.Education.Universities.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Member.Education.Universities;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Education.Universities.Handlers.List
{
    public class GetEbaUniversityQueryHandler : IRequestHandler<GetEbaUniversityQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<ST_Universities> genericRepository;
        private readonly IMapper mapper;

        public GetEbaUniversityQueryHandler(IEbaGenericRepository<ST_Universities> genericRepository, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaUniversityQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await genericRepository.GetAllAsync()).OrderBy(x=>x.ID);

            return mapper.Map<IEnumerable<ST_Universities>, ICollection<EbaStrKvpDto>>(data);
        }
    }
}
