using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class WorkModel : BaseEntity
    {
        public string? WorkModelKey { get; set; }
        public string WorkModelName { get; set; }
        public Guid AdvertCreateId { get; set; }
        public AdvertCreate AdvertCreate { get; set; }
    }
}
