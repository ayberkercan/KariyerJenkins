using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class JobCategory : BaseEntity
    {
        public string? JobCategoryKey { get; set; }
        public string JobCategoryName { get; set; }
    }
}
