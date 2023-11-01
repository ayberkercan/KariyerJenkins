using AutoMapper;
using EKSystemApp.Application.DTO.ExperiencePeriod;
using EKSystemApp.Application.Features.ExperiencePeriods.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.ExperiencePeriods.Handler.List
{
    public class GetExperiencePeriodsQueryHandler : IRequestHandler<GetExperiencePeriodsQueryRequest, ICollection<ExperiencePeriodDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<ExperiencePeriod> genericRepository;
        public GetExperiencePeriodsQueryHandler(IMapper mapper, IGenericRepository<ExperiencePeriod> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<ExperiencePeriodDto>> Handle(GetExperiencePeriodsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<ExperiencePeriodDto>>(data);
        }
    }
}
