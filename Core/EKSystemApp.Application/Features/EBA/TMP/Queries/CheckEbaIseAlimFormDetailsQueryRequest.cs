using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class CheckEbaIseAlimFormDetailsQueryRequest : IRequest<ICollection<EbaIseAlimTurkuvazFormDto>>
    {
        public int ProcessId { get; set; }
        public CheckEbaIseAlimFormDetailsQueryRequest(int ProcessId)
        {
            this.ProcessId = ProcessId;
        }
    }
}
