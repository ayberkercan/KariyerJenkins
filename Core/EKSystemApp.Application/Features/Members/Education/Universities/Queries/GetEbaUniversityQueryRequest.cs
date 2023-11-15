using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Education.Universities.Queries
{
    public class GetEbaUniversityQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
    }
}
