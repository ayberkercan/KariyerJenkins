using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.eBA.ForeignLanguages;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaForeignLanguageLevelsQueryHandler : IRequestHandler<GetEbaForeignLanguageLevelsQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<LanguageLevels> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaForeignLanguageLevelsQueryHandler(IEbaGenericRepository<LanguageLevels> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaForeignLanguageLevelsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.ORDER);

            var result = _mapper.Map<List<EbaStrKvpDto>>(data);

            return result;
        }
    }
}
