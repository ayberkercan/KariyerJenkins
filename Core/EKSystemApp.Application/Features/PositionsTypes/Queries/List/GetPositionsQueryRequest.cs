using EKSystemApp.Application.DTO.PositionsTypes.List;
using MediatR;

namespace EKSystemApp.Application.Features.PositionsTypes.Queries.List
{
    public class GetPositionsQueryRequest : IRequest<ICollection<PositionsTypesDto>>
    {
    }
}
