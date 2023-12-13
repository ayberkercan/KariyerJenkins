using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class EducationLevel : BaseEntity
    {
        public string? EducationLevelKey { get; set; }
        public string EducationLevelName { get; set; }
        public Guid AdvertCreateId { get; set; }
        public AdvertCreate AdvertCreate { get; set; }
    }
}
