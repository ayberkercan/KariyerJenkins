using EKSystemApp.Application.DTO.PositionsTypes;
using MediatR;

namespace EKSystemApp.Application.Features.PositionsTypes.Queries.List
{
    public class GetPositionsTypeQueryRequest : IRequest<ICollection<PositionsTypesDto>>
    {
    }
}
