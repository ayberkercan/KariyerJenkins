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
    public class GetEbaWorkingTypeQueryHandler : IRequestHandler<GetEbaWorkingTypeQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaGenericRepository<WorkingType> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaWorkingTypeQueryHandler(IEbaGenericRepository<WorkingType> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaWorkingTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _genericRepository.GetAllAsync();

            var result = _mapper.Map<List<EbaKvpDto>>(data).OrderBy(x => x.Key).ToList();

            return result;
        }
    }
}
