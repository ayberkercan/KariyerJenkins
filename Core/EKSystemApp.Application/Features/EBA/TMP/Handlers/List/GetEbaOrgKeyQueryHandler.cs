using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaOrgKeyQueryHandler : IRequestHandler<GetEbaOrgKeyQueryRequest, ICollection<EbaOrgKeyStrKvpDto>>
    {
        private readonly IEbaGenericRepository<TmpZhrCalisanPersWs> genericRepository;
        private readonly IMapper mapper;

        public GetEbaOrgKeyQueryHandler(IEbaGenericRepository<TmpZhrCalisanPersWs> genericRepository, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }
        public async Task<ICollection<EbaOrgKeyStrKvpDto>> Handle(GetEbaOrgKeyQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await this.genericRepository.GetAllAsync();
            var orgKeyList = userData.DistinctBy(x => x.ORGKEY).Where(x => x.IKONAYCI.Contains(Convert.ToString(request.Request.UserId))).OrderBy(x => x.ORGKEY);
            return this.mapper.Map<ICollection<EbaOrgKeyStrKvpDto>>(orgKeyList);
        }
    }
}
