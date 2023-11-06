using EKSystemApp.Application.DTO.AdPublisher;
using MediatR;

namespace EKSystemApp.Application.Features.AdPublishers
{
    public class GetAdPublisherQueryRequest : IRequest<ICollection<AdPublishersDto>>
    {
    }
}
