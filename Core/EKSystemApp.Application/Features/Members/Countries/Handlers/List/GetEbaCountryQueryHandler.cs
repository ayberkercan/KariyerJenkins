using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Members.Countries.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Member.Countries;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Countries.Handlers.List
{
    public class GetEbaCountryQueryHandler : IRequestHandler<GetEbaCountryQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<ST_Countries> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaCountryQueryHandler(IEbaGenericRepository<ST_Countries> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaCountryQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.TANIM.Split("")[0]);

            return _mapper.Map<IEnumerable<ST_Countries>, ICollection<EbaStrKvpDto>>(data);
        }
    }
}
