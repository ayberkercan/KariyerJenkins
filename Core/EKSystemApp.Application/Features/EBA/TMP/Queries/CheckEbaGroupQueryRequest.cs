using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class CheckEbaGroupQueryRequest : IRequest<ICollection<EbaKvpDto>>
    {
        public int UpKey { get; set; }
        public CheckEbaGroupQueryRequest(int upKey)
        {
            UpKey = upKey;
        }
    }
}
