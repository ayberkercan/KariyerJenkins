using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class Location : BaseEntity
    {
        public string? LocationKey { get; set; }
        public string LocationName { get; set; }
        public Guid AdvertCreateId { get; set; }
        public AdvertCreate AdvertCreate { get; set; }
    }
}