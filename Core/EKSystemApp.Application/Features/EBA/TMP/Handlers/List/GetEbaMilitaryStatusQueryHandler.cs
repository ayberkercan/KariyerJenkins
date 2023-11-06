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
    public class GetEbaMilitaryStatusQueryHandler : IRequestHandler<GetEbaMilitaryStatusQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<MilitaryStatus> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaMilitaryStatusQueryHandler(IEbaGenericRepository<MilitaryStatus> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaMilitaryStatusQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync())
                        .OrderByDescending(x=>x.ID)
                        .ToList();

            var result = _mapper.Map<List<EbaStrKvpDto>>(data);

            return result;
        }
    }
}
