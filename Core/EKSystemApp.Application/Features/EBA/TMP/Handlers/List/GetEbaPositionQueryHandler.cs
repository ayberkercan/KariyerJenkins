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
    public class GetEbaPositionQueryHandler : IRequestHandler<GetEbaPositionQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaGenericRepository<Titles> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaPositionQueryHandler(IEbaGenericRepository<Titles> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaPositionQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await _genericRepository.GetAllAsync();

            var result = _mapper.Map<List<EbaKvpDto>>(userData).OrderBy(x => x.Value).ToList();
            
            return result;
        }
    }
}
