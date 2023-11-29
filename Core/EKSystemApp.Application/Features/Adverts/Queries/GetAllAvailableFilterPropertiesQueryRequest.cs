using EKSystemApp.Application.DTO.Advert.List;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Queries
{
    public class GetAllAvailableFilterPropertiesQueryRequest : IRequest<FilterPropertiesTreeDto>
    {
    }
}
