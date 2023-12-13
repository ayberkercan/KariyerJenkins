using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class Unit : BaseEntity
    {
        public string? UnitKey { get; set; }
        public string UnitName{ get; set; }
        public Guid AdvertCreateId { get; set; }
        public AdvertCreate AdvertCreate { get; set; }
    }
}
