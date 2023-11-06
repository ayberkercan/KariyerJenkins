using EKSystemApp.Application.DTO.Eba.EbaPosition;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.EbaPositions.Queries
{
    public class GetEbaPositionQueryRequest:IRequest<ICollection<EbaPositionDto>>
    {
    }
}
