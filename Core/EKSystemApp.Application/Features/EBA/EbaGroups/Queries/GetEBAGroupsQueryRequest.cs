using EKSystemApp.Application.DTO.Eba.EbaGroup;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.EbaGroups.Queries
{
    public class GetEBAGroupsQueryRequest : IRequest<ICollection<EbaGroupDto>>
    {
    }
}
