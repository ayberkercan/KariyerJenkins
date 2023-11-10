using AutoMapper;
using EKSystemApp.Application.DTO.MillitaryStatus;
using EKSystemApp.Application.DTO.SkillAndExpertis;
using EKSystemApp.Application.Features.SkillAndExpertises.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.SkillAndExpertises.Handler.List
{
    public class GetSkillAndExpertisesQueryHandler : IRequestHandler<GetSkillAndExpertisesQueryRequest, ICollection<SkillAndExpertiseDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<AdvertSkillAndExpertises> genericRepository;

        public GetSkillAndExpertisesQueryHandler(IMapper mapper, IGenericRepository<AdvertSkillAndExpertises> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<SkillAndExpertiseDto>> Handle(GetSkillAndExpertisesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<SkillAndExpertiseDto>>(data);
        }
    }
}
