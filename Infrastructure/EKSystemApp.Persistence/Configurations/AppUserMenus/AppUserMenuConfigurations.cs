using EKSystemApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EKSystemApp.Persistence.Configurations.AppUserMenus
{
    public class AppUserMenuConfigurations : IEntityTypeConfiguration<AppUserMenu>
    {
        public void Configure(EntityTypeBuilder<AppUserMenu> builder)
        {
            builder
                .HasKey(x => new
                {
                    x.AppUserId,
                    x.MenuId,

                });
            builder
               .HasOne(p => p.AppUser)
                .WithMany(x => x.AppUserMenus)
                .HasForeignKey(p => p.AppUserId);
            
            builder
                .HasOne(p => p.Menu)
                .WithMany(x => x.AppUserMenus)
                .HasForeignKey(p => p.MenuId);

        }
    }
}
