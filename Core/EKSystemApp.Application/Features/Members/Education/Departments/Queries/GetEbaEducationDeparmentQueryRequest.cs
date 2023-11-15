using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Education.Departments.Queries
{
    public class GetEbaEducationDeparmentQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
    }
}
