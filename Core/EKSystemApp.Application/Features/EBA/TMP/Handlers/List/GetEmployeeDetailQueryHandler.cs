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
    public class GetEmployeeDetailQueryHandler : IRequestHandler<GetEbaEmployeeDetailRequest, ICollection<TmpZhrCalisanPersWsDto>>
    {
        private readonly IEbaGenericRepository<TmpZhrCalisanPersWs> _genericRepository;
        private readonly IMapper _mapper;

        public GetEmployeeDetailQueryHandler(IEbaGenericRepository<TmpZhrCalisanPersWs> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<TmpZhrCalisanPersWsDto>> Handle(GetEbaEmployeeDetailRequest request, CancellationToken cancellationToken)
        {
            var userData = await _genericRepository.GetAllAsync();

            return _mapper.Map<ICollection<TmpZhrCalisanPersWsDto>>(userData);
        }
    }
}
