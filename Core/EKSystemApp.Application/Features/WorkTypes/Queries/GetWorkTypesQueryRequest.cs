using EKSystemApp.Application.DTO.WorkType;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.WorkTypes.Queries
{
    public class GetWorkTypesQueryRequest:IRequest<ICollection<WorkTypeDto>>
    {
    }
}
