using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaOrganizationQueryHandler : IRequestHandler<GetEbaOrganizationQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<TmpZhrCalisanPersWs> genericRepository;
        private readonly IMapper mapper;

        public GetEbaOrganizationQueryHandler(IEbaGenericRepository<TmpZhrCalisanPersWs> genericRepository, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }
        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaOrganizationQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await this.genericRepository.GetAllAsync();
            var orgList = userData.DistinctBy(x => x.ZORG).Where(x => x.ZORG != "0").OrderBy(x => x.ORGTX);
            return this.mapper.Map<ICollection<EbaStrKvpDto>>(orgList);
            //return this.mapper.Map<IEnumerable<TmpZhrCalisanPersWs>, ICollection<EbaStrKvpDto>>(orgList);
        }
    }
}
