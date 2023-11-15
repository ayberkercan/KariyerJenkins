using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class CheckEbaProfessionQueryRequest : IRequest<ICollection<EbaKvpDto>>
    {
        public string OrgId { get; set; }
        public string? GroupId { get; set; }
        public string? DepartmentId { get; set; }
        public string? UnitId { get; set; }
        public CheckEbaProfessionQueryRequest(string OrgId, string? GroupId, string? DepartmentId, string? UnitId)
        {
            this.OrgId = OrgId;
            this.GroupId = GroupId;
            this.DepartmentId = DepartmentId;
            this.UnitId = UnitId;
        }
    }
}
