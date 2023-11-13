using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKSystemApp.Persistence.Configurations.AdminPages
{
    public class AdvertConfigurations : IEntityTypeConfiguration<AdvertCreate>
    {
        public void Configure(EntityTypeBuilder<AdvertCreate> builder)
        {
            //builder
            //.HasMany(p => p.SkillAndExpertises)
            //.WithOne(p => p.AdvertCreate)
            //.HasForeignKey(p => p.AdvertCreateId)
            //.OnDelete(DeleteBehavior.NoAction);

            //builder
            //    .HasMany(p => p.ForeignLanguages)
            //    .WithOne(p => p.AdvertCreate)
            //    .HasForeignKey(p => p.AdvertCreateId)
            //    .OnDelete(DeleteBehavior.NoAction);
            //builder
            //    .HasMany(p => p.AddQuestions)
            //    .WithOne(p => p.AdvertCreate)
            //    .HasForeignKey(p => p.AdvertCreateId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
