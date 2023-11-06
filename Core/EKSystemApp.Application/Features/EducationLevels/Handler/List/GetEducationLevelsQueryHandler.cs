using AutoMapper;
using EKSystemApp.Application.DTO.EducationLevel;
using EKSystemApp.Application.Features.EducationLevels.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.EducationLevels.Handler.List
{
    public class GetEducationLevelsQueryHandler : IRequestHandler<GetEducationLevelsQueryRequest, ICollection<EducationLevelDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<EducationLevel> genericRepository;
        public GetEducationLevelsQueryHandler(IMapper mapper, IGenericRepository<EducationLevel> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<EducationLevelDto>> Handle(GetEducationLevelsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<EducationLevelDto>>(data);
        }
    }
}
