using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEmployeeDetailQueryHandler : IRequestHandler<GetEbaEmployeeDetailRequest, ICollection<TmpZhrCalisanPersWsDto>>
    {
        private readonly IEbaGenericRepository<TmpZhrCalisanPersWs> genericRepository;
        private readonly IMapper mapper;

        public GetEmployeeDetailQueryHandler(IEbaGenericRepository<TmpZhrCalisanPersWs> genericRepository, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<TmpZhrCalisanPersWsDto>> Handle(GetEbaEmployeeDetailRequest request, CancellationToken cancellationToken)
        {
            var userData = await this.genericRepository.GetAllAsync();
            return this.mapper.Map<ICollection<TmpZhrCalisanPersWsDto>>(userData);
        }
    }
}
