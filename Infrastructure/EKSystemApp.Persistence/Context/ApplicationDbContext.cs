using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.Blog;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Domain.Entities.File;
using EKSystemApp.Domain.Entities.UI.SavedFilters;
using EKSystemApp.Persistence.Configurations.AdminPages;
using EKSystemApp.Persistence.Configurations.AppMenus;
using EKSystemApp.Persistence.Configurations.AppUserCompanies;
using EKSystemApp.Persistence.Configurations.AppUserMenus;
using EKSystemApp.Persistence.Configurations.AppUsers;
using EKSystemApp.Persistence.Configurations.Companies;
using EKSystemApp.Persistence.Configurations.Menus;
using EKSystemApp.Persistence.Configurations.Products;
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
            #region Configuration
            modelBuilder.ApplyConfiguration(new AppUserConfigurations());
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            modelBuilder.ApplyConfiguration(new CompanyConfigurations());
            modelBuilder.ApplyConfiguration(new MenuItemConfigurations());
            modelBuilder.ApplyConfiguration(new AppUserCompanyConfigurations());
            modelBuilder.ApplyConfiguration(new AppUserMenuConfigurations());
            modelBuilder.ApplyConfiguration(new AdvertConfigurations());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            base.OnModelCreating(modelBuilder);
            #endregion
        }

        #region DBSET
        #region User
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyKey> CompanyKeys { get; set; }
        public DbSet<AppUserCompany> AppUserCompany { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<AppUserMenu> AppUserMenus { get; set; }
        public DbSet<AppUserItem> AppUserItems { get; set; }

        #endregion

        #region New Advert Create
        public DbSet<AdvertCreate> AdvertCreates { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<PositionType> PositionTypes { get; set; }
        public DbSet<WorkModel> WorkModels { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<MillitaryStatus> MillitaryStatuses { get; set; }
        public DbSet<AdvertStatus> AdvertStatuses { get; set; }
        public DbSet<AdvertSkillAndExpertises> AdvertSkillAndExpertises { get; set; }
        public DbSet<AdvertForeignLanguages> AdvertForeignLanguages { get; set; }
        public DbSet<AdvertAdQuestions> AdvertAdQuestions { get; set; }
        public DbSet<WorkCategory> WorkCategories { get; set; }
        public DbSet<ExperiencePeriod> ExperiencePeriods { get; set; }
        #endregion

        #region Blog
        public DbSet<BlogHeadlineManager> BlogHeadlineManagers { get; set; }
        #endregion
        public DbSet<Domain.Entities.Admin.Eba.Profession> Professions { get; set; }
        public DbSet<SavedFiltersOfApprovedCandidateList> SavedFiltersOfApprovedCandidateList { get; set; }
        public DbSet<AdPublisher> AdPublishers { get; set; }
        public DbSet<AdvertAdQuestionAnswerContent> AdvertAdQuestionAnswerContent { get; set; }
        public DbSet<FormFiles> FormFiles { get; set; }
        #endregion
    }
}
