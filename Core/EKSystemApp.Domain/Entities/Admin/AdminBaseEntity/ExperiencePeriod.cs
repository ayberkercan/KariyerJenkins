using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class ExperiencePeriod : BaseEntity
    {
        public string? ExperiencePeriodKey { get; set; }
        public string? ExperiencePeriodName { get; set; }
        public Guid? AdvertCreateId { get; set; }
        public AdvertCreate? AdvertCreate { get; set; }
    }
}
