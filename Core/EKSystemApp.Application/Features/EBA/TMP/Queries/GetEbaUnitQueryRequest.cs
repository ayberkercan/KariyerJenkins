using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class GetEbaUnitQueryRequest : IRequest<ICollection<EbaKvpDto>>
    {
        public CheckEbaUnitQueryRequest Request { get; set; }
        public GetEbaUnitQueryRequest(CheckEbaUnitQueryRequest request)
        {
            Request = request;
        }
    }
}
