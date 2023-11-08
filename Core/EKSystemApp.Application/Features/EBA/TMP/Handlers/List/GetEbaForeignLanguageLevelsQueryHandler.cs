using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA.ForeignLanguages;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaForeignLanguageLevelsQueryHandler : IRequestHandler<GetEbaForeignLanguageLevelsQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<LanguageLevels> _genericRepository;
        private readonly IMapper mapper;

        public GetEbaForeignLanguageLevelsQueryHandler(IEbaGenericRepository<LanguageLevels> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaForeignLanguageLevelsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.ORDER);

            var result = this.mapper.Map<List<EbaStrKvpDto>>(data);
            return this.mapper.Map<ICollection<EbaStrKvpDto>>(result);
        }
    }
}
