using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Provinces;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Features.Members.Provinces.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.Member.Countries;
using EKSystemApp.Domain.Entities.Member.Provinces;
using MediatR;

namespace EKSystemApp.Application.Features.Provinces.Members.Handlers.List
{
    public class GetEbaProvinceQueryHandler : IRequestHandler<GetEbaProvinceQueryRequest, ICollection<ST_ProvincesDto>>
    {
        private readonly IEbaGenericRepository<ST_Provinces> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaProvinceQueryHandler(IEbaGenericRepository<ST_Provinces> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<ST_ProvincesDto>> Handle(GetEbaProvinceQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).Where(x=>x.UpKey == request.upKey).OrderBy(x => x.Value);

            return _mapper.Map<IEnumerable<ST_Provinces>, ICollection<ST_ProvincesDto>>(data);
        }
    }
}
