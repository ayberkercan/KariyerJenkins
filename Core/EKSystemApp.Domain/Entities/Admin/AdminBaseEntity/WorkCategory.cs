using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class WorkCategory : BaseEntity
    {
        public string? WorkCategoryKey { get; set; }
        public string? WorkCategoryName { get; set; }
        public Guid? AdvertCreateId { get; set; }
        public AdvertCreate? AdvertCreate { get; set; }
    }
}
