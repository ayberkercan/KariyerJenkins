using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Features.Members.Countries.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.Member.Countries;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Countries.Handlers.List
{
    public class GetEbaCountryQueryHandler : IRequestHandler<GetEbaCountryQueryRequest, ICollection<ST_CountriesDto>>
    {
        private readonly IEbaGenericRepository<ST_Countries> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaCountryQueryHandler(IEbaGenericRepository<ST_Countries> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<ST_CountriesDto>> Handle(GetEbaCountryQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.Value);

            return _mapper.Map<IEnumerable<ST_Countries>, ICollection<ST_CountriesDto>>(data);
        }
    }
}
