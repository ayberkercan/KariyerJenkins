using EKSystemApp.Application.DTO.MillitaryStatus;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.MillitaryStatuses.Queries
{
    public class GetMillitaryStatusesQueryRequest:IRequest<ICollection<MillitaryStatusDto>>
    {
    }
}
