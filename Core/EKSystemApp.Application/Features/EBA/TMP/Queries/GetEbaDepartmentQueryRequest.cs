using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class GetEbaDepartmentQueryRequest : IRequest<ICollection<EbaKvpDto>>
    {
        public CheckEbaDepartmentQueryRequest Request { get; set; }
        public GetEbaDepartmentQueryRequest(CheckEbaDepartmentQueryRequest request)
        {
            Request = request;
        }
    }
}
