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
    public class GetSkillAndExpertisesQueryHandler : IRequestHandler<GetSkillAndExpertisesQueryRequest, ICollection<SkillAndExpertisDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<MillitaryStatus> genericRepository;

        public GetSkillAndExpertisesQueryHandler(IMapper mapper, IGenericRepository<MillitaryStatus> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<SkillAndExpertisDto>> Handle(GetSkillAndExpertisesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<SkillAndExpertisDto>>(data);
        }
    }
}
