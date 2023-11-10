using AutoMapper;
using EKSystemApp.Application.DTO.Member.Cities;
using EKSystemApp.Application.Features.Members.Cities.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Member.Cities;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Cities.Handlers.List
{
    public class GetEbaCityQueryHandler : IRequestHandler<GetEbaCityQueryRequest, ICollection<ST_CitiesDto>>
    {
        private readonly IEbaGenericRepository<ST_Cities> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaCityQueryHandler(IEbaGenericRepository<ST_Cities> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<ST_CitiesDto>> Handle(GetEbaCityQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).Where(x => x.UpKey == request.upKey).OrderBy(x => x.Value);

            return _mapper.Map<IEnumerable<ST_Cities>, ICollection<ST_CitiesDto>>(data);
        }
    }
}
