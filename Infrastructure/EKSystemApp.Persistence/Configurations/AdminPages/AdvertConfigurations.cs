using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKSystemApp.Persistence.Configurations.AdminPages
{
    public class AdvertConfigurations : IEntityTypeConfiguration<AdvertCreate>
    {
        public void Configure(EntityTypeBuilder<AdvertCreate> builder)
        {
            builder
               .HasMany(p => p.MillitaryStatuses)
               .WithOne(p => p.AdvertCreate)
               .HasForeignKey(p => p.AdvertCreateId)
               .OnDelete(DeleteBehavior.NoAction);
            builder
               .HasMany(p => p.MillitaryStatuses)
               .WithOne(p => p.AdvertCreate)
               .HasForeignKey(p => p.AdvertCreateId)
               .OnDelete(DeleteBehavior.NoAction);
            builder
               .HasMany(p => p.Organizations)
               .WithOne(p => p.AdvertCreate)
               .HasForeignKey(p => p.AdvertCreateId)
               .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.Groups)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.Departments)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.PositionTypes)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.WorkModels)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.Locations)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.EducationLevels)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.WorkTypes)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.Positions)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.Brands)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.AdvertStatuses)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
             builder
                .HasMany(p => p.AdvertStatuses)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.WorkCategories)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.ExperiencePeriods)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.AdvertSkillAndExpertises)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(p => p.AdvertForeignLanguages)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.AdvertAdQuestions)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.Logos)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
