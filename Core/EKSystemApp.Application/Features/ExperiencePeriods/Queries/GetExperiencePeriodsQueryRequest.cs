using EKSystemApp.Application.DTO.ExperiencePeriod;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.ExperiencePeriods.Queries
{
    public class GetExperiencePeriodsQueryRequest:IRequest<ICollection<ExperiencePeriodDto>>
    {
    }
}
