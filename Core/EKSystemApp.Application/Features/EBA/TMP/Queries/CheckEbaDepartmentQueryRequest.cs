using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class CheckEbaDepartmentQueryRequest : IRequest<ICollection<EbaKvpDto>>
    {
        public int UpKey { get; set; }
    }
}
