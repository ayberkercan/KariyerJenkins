using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class GetEbaGroupQueryRequest : IRequest<ICollection<EbaKvpDto>>
    {
        public CheckEbaGroupQueryRequest Request { get; set; }
        public GetEbaGroupQueryRequest(CheckEbaGroupQueryRequest request)
        {
            Request = request;
        }
    }
}
