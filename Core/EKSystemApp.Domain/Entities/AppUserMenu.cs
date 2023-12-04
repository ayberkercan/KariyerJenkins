namespace EKSystemApp.Domain.Entities
{
    public class AppUserMenu
    {
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Guid? MenuId { get; set; }
        public Menu? Menu { get; set; }
    }
}
