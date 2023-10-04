using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EKSystemApp.Persistence.Configurations.CompanyMenus
{
    public class CompanyMenuConfigurations : IEntityTypeConfiguration<CompanyMenu>
    {
        public void Configure(EntityTypeBuilder<CompanyMenu> builder)
        {
            builder
                .HasKey(x => new
                {
                    x.CompanyId,
                    x.MenuId,

                });

            builder
                .HasOne(p => p.Menu)
                .WithMany(x => x.CompanyMenues)
                .HasForeignKey(p => p.MenuId);
            builder
                .HasOne(p => p.Company)
                .WithMany(x => x.CompanyMenues)
                .HasForeignKey(p => p.CompanyId);
        }
    }
}
