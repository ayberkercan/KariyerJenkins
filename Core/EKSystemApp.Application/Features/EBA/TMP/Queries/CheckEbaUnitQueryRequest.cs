using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class CheckEbaUnitQueryRequest : IRequest<ICollection<EbaKvpDto>>
    {
        public int UpKey { get; set; }
        public CheckEbaUnitQueryRequest(int UpKey)
        {
            this.UpKey = UpKey;
        }
    }
}
