using EKSystemApp.Application.DTO.Advert.List;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Queries
{
    public class GetAllAdvertsQueryRequest : IRequest<ICollection<AdvertListDto>>
    {
    }
}
