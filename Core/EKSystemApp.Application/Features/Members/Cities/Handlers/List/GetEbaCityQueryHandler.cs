using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Members.Cities.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Member.Cities;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Cities.Handlers.List
{
    public class GetEbaCityQueryHandler : IRequestHandler<GetEbaCityQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<ST_Cities> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaCityQueryHandler(IEbaGenericRepository<ST_Cities> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaCityQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).Where(x => x.IL_ID == request.UpKey).OrderBy(x => x.ISIM);

            return _mapper.Map<IEnumerable<ST_Cities>, ICollection<EbaStrKvpDto>>(data);
        }
    }
}
