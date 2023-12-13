using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class Position : BaseEntity
    {
        public string? PositionKey { get; set; }
        public string PositionName { get; set; }
        public Guid AdvertCreateId { get; set; }
        public AdvertCreate AdvertCreate { get; set; }
    }
}
