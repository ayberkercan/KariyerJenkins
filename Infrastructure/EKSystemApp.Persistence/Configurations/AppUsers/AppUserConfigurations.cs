using EKSystemApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKSystemApp.Persistence.Configurations.AppUsers
{
    public class AppUserConfigurations : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {

            #region User - Role
            builder
              .HasOne(x => x.AppRoles)
              .WithMany(p => p.AppUsers)
              .HasForeignKey(x => x.AppRoleId)
              .OnDelete(DeleteBehavior.Restrict);
            #endregion


        }
    }
}
