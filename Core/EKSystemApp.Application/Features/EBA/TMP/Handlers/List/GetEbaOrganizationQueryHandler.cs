using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaOrganizationQueryHandler : IRequestHandler<GetEbaOrganizationQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<TmpZhrCalisanPersWs> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaOrganizationQueryHandler(IEbaGenericRepository<TmpZhrCalisanPersWs> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaOrganizationQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await _genericRepository.GetAllAsync();

            var orgList = userData.DistinctBy(x => x.ZORG).Where(x => x.ZORG != "0").OrderBy(x => x.ORGTX);

            return _mapper.Map<IEnumerable<TmpZhrCalisanPersWs>, ICollection<EbaStrKvpDto>>(orgList);
        }
    }
}
