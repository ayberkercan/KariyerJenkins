using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Countries.Queries
{
    public class GetEbaCountryQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
    }
}
