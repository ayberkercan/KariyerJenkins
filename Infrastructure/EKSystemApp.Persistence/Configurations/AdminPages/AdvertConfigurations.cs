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
                .HasMany(p => p.Positions)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.TasksTypes)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.EBACompanies)
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
                .HasMany(p => p.Units)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.WorkTypes)
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
                .HasMany(p => p.ExperiencePeriods)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.MillitaryStatuses)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.ForignLanguages)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.JobCategories)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.AdStatuses)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.AdPublishers)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(p => p.AdQuestions)
                .WithOne(p => p.AdvertCreate)
                .HasForeignKey(p => p.AdvertCreateId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
