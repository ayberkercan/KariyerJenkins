using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA.GeneralSkills;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaGeneralSkillLevelsQueryHandler : IRequestHandler<GetEbaGeneralSkillLevelsQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<SkillLevels> _genericRepository;
        private readonly IMapper mapper;

        public GetEbaGeneralSkillLevelsQueryHandler(IEbaGenericRepository<SkillLevels> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaGeneralSkillLevelsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.ORDER);
            var result = this.mapper.Map<List<EbaStrKvpDto>>(data);
            return this.mapper.Map<ICollection<EbaStrKvpDto>>(result);
        }
    }
}
