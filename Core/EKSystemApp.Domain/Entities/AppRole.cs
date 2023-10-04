using Microsoft.AspNetCore.Identity;

namespace EKSystemApp.Domain.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string? Definition { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }

    }
}
