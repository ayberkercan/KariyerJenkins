using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class GetEbaIseAlimFormDetailsQueryRequest : IRequest<EbaIseAlimTurkuvazFormDto>
    {
        public CheckEbaIseAlimFormDetailsQueryRequest Request { get; set; }
        public GetEbaIseAlimFormDetailsQueryRequest(CheckEbaIseAlimFormDetailsQueryRequest request)
        {
            Request = request;
        }
    }
}
