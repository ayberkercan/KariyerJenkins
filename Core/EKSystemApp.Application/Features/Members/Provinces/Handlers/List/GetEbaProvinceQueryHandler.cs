using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Members.Provinces.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Member.Provinces;
using MediatR;

namespace EKSystemApp.Application.Features.Provinces.Members.Handlers.List
{
    public class GetEbaProvinceQueryHandler : IRequestHandler<GetEbaProvinceQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<ST_Provinces> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaProvinceQueryHandler(IEbaGenericRepository<ST_Provinces> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaProvinceQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).Where(x=> request.UpKey == "TR").OrderBy(x => x.PLAKA);

            return _mapper.Map<IEnumerable<ST_Provinces>, ICollection<EbaStrKvpDto>>(data);
        }
    }
}
