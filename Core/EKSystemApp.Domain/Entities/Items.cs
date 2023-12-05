using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities
{
    public class Items : BaseEntity
    {
        public int KeyId { get; set; }
        public string Label { get; set; }
        public string Icon { get; set; }
        public string RouterLink { get; set; }
        public string? url { get; set; }
        public bool? queryParams { get; set; }
        public Guid? MenuId { get; set; }
        public Menu? Menu { get; set; }
        public ICollection<AppUserItem> AppUserItems { get; set; }
    }
}
