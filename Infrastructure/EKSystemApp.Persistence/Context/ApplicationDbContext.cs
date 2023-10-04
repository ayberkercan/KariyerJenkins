using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.Eba;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Persistence.Configurations;
using EKSystemApp.Persistence.Configurations.Admin;
using EKSystemApp.Persistence.Configurations.AppMenu;
using EKSystemApp.Persistence.Configurations.Companies;
using EKSystemApp.Persistence.Configurations.CompanyMenus;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EKSystemApp.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfigurations());
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            modelBuilder.ApplyConfiguration(new CompanyConfigurations());
            modelBuilder.ApplyConfiguration(new MenuConfigurations());
            modelBuilder.ApplyConfiguration(new AppUserCompanyConfigurations());
            modelBuilder.ApplyConfiguration(new CompanyMenuConfigurations());
            modelBuilder.ApplyConfiguration(new AdwertConfigurations());
            base.OnModelCreating(modelBuilder);
        }
        #region DBSET
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUserCompany> AppUserCompany { get; set; }
        public DbSet<AdvertCreate> AdvertCreates { get; set; }
        public DbSet<CompanyMenu> CompanyMenus { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<EBACompany> EBACompanies { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Group> Groups { get; set; }
        //public DbSet<Group> Groups { get; set; }
        //public DbSet<Group> Groups { get; set; }
        #endregion



    }
}
