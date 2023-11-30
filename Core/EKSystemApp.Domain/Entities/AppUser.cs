using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using Microsoft.AspNetCore.Identity;

namespace EKSystemApp.Domain.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Registry { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public Guid AppRoleId { get; set; }
        public AppRole AppRoles { get; set; }
        public ICollection<AppUserCompany> AppUserCompanies { get; set; }
        public ICollection<AppUserMenu> AppUserMenus { get; set; }
        public ICollection<AdvertCreate> AdvertCreates { get; set; }
    }
}
