using EKSystemApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKSystemApp.Persistence.Configurations.Companies
{
    public class CompanyConfigurations : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {

            builder.HasData(
                new Company
                {
                    Id = Guid.NewGuid(),
                    CompanyName = "Holding",
                },
                new Company
                {
                    Id = Guid.NewGuid(),
                    CompanyName = "D&R"
                },
                 new Company
                 {
                     Id = Guid.NewGuid(),
                     CompanyName = "D&R Market"
                 }
                );

            builder
                .HasMany(p => p.CompanyKeys)
                .WithOne(p => p.Company)
                .HasForeignKey(p => p.Id)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
