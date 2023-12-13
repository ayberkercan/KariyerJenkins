using EKSystemApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKSystemApp.Persistence.Configurations.AppMenus
{
    public class MenuItemConfigurations : IEntityTypeConfiguration<AppUserItem>
    {
        public void Configure(EntityTypeBuilder<AppUserItem> builder)
        {
            builder
             .HasKey(x => new
             {
                 x.AppUserId,
                 x.ItemId,
             });
            builder
               .HasOne(p => p.AppUser)
                .WithMany(x => x.AppUserItems)
                .HasForeignKey(p => p.AppUserId);

            builder
                .HasOne(p => p.Items)
                .WithMany(x => x.AppUserItems)
                .HasForeignKey(p => p.ItemId);
        }
    }
}
