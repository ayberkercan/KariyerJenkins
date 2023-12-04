using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public int KeyId { get; set; }
        public string Label { get; set; }
        public string Icon { get; set; }
        public string RouterLink { get; set; }
        public ICollection<AppUserMenu> AppUserMenus { get; set; }
        public ICollection<Items>? Items { get; set; }
    }
}