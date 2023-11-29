using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string RouterLink { get; set; }
        public string RouterIcon { get; set; }
        public string HtmlTag { get; set; }
        public ICollection<AppUserMenu> AppUserMenus { get; set; }

    }
}