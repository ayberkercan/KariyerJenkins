using EKSystemApp.Domain.Entities.Admin.MailMesaj;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKSystemApp.Persistence.Configurations.MailMessage
{
    public class MailMessageConfiguration : IEntityTypeConfiguration<MailMessageTemplate>
    {
        public void Configure(EntityTypeBuilder<MailMessageTemplate> builder)
        {
            builder
                .HasOne(p => p.AppUser)
                .WithMany(p => p.MailMessageTemplates)
                .HasForeignKey(p => p.AppUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
