using EKSystemApp.Application.DTO.Eba.EbaOrganization;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.EbaOrganization.Queries
{
    public class GetEbaOrganizationQueryRequest:IRequest<ICollection<EbaOrganizationDto>>
    {
    }
}
