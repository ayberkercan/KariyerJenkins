using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class AdStatus : BaseEntity
    {
        public string? AdStatusKey { get; set; }
        public string AdStatusName { get; set; }
    }
}
