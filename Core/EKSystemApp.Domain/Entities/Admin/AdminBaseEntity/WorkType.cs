using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class WorkType : BaseEntity
    {
        public string? WorkTypeKey { get; set; }
        public string WorkTypeName { get; set; }
        public Guid AdvertCreateId { get; set; }
        public AdvertCreate AdvertCreate  { get; set; }
    }
}
