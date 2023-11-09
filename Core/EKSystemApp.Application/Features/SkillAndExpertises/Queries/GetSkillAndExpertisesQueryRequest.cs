using EKSystemApp.Application.DTO.SkillAndExpertis;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.SkillAndExpertises.Queries
{
    public class GetSkillAndExpertisesQueryRequest:IRequest<ICollection<SkillAndExpertiseDto>>
    {
    }
}
