using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class GetEbaOrgKeyQueryRequest : IRequest<ICollection<EbaOrgKeyStrKvpDto>>
    {
        public CheckEbaOrgKeyQueryRequest Request { get; set; }
        public GetEbaOrgKeyQueryRequest(CheckEbaOrgKeyQueryRequest request)
        {
            Request = request;
        }
    }
}
