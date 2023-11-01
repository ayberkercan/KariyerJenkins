using EKSystemApp.Application.DTO.EducationLevel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EducationLevels.Queries
{
    public class GetEducationLevelsQueryRequest:IRequest<ICollection<EducationLevelDto>>
    {
    }
}
