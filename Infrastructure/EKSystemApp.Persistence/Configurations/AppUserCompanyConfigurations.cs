﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKSystemApp.Persistence.Configurations
{
    public class AppUserCompanyConfigurations : IEntityTypeConfiguration<AppUserCompany>
    {
        public void Configure(EntityTypeBuilder<AppUserCompany> builder)
        {
            builder
                .HasKey(x => new
                {
                    x.AppUserId,
                    x.CompanyId,

                });

            builder
                .HasOne(p => p.AppUser)
                .WithMany(x => x.AppUserCompanies)
                .HasForeignKey(p => p.AppUserId);
            builder
                .HasOne(p => p.Company)
                .WithMany(x => x.AppUserCompanies)
                .HasForeignKey(p => p.CompanyId);
        }
    }
}
