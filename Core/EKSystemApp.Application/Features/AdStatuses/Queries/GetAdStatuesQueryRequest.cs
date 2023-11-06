using EKSystemApp.Application.DTO.AdStatus;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.AdStatuses.Queries
{
    public class GetAdStatuesQueryRequest: IRequest<ICollection<AdStatusDto>>
    {
    }
}
