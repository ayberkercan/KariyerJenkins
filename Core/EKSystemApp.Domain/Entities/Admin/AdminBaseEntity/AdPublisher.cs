using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class AdPublisher : BaseEntity
    {
        public string? AdPublisherKey { get; set; }
        public string AdPublisherName { get; set; }
    }
}
