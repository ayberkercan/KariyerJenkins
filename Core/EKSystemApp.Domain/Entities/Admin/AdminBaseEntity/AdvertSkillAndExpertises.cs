using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class AdvertSkillAndExpertises : BaseEntity
    {
        public string? SkillAndExpertiseKey { get; set; }
        public string? SkillAndExpertiseName { get; set; }
        public Guid? AdvertCreateId { get; set; }
        public AdvertCreate? AdvertCreate { get; set; }
    }
}
