using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.Eba;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Domain.Entities.Admin.SavedFilters;
using EKSystemApp.Persistence.Configurations.AdminPages;
using EKSystemApp.Persistence.Configurations.AppMenus;
using EKSystemApp.Persistence.Configurations.AppUserCompanies;
using EKSystemApp.Persistence.Configurations.AppUserMenus;
using EKSystemApp.Persistence.Configurations.AppUsers;
using EKSystemApp.Persistence.Configurations.Companies;
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
            modelBuilder.ApplyConfiguration(new AppUserConfigurations());
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            modelBuilder.ApplyConfiguration(new CompanyConfigurations());
            modelBuilder.ApplyConfiguration(new MenuConfigurations());
            modelBuilder.ApplyConfiguration(new AppUserCompanyConfigurations());
            modelBuilder.ApplyConfiguration(new AppUserMenuConfigurations());
            modelBuilder.ApplyConfiguration(new AdvertConfigurations());
            base.OnModelCreating(modelBuilder);
        }
        #region DBSET
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AdvertAdQuestions> AdvertAdQuestions { get; set; }
        public DbSet<AdvertAdQuestionAnswerContent> AdvertAdQuestionAnswerContent { get; set; }
        public DbSet<AdvertForignLanguages> AdvertForignLanguages { get; set; }
        public DbSet <AdvertSkillAndExpertises> AdvertSkillAndExpertises { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUserCompany> AppUserCompany { get; set; }
        public DbSet<AdvertCreate> AdvertCreates { get; set; }
        public DbSet<AppUserMenu> AppUserMenus { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<EbaCompany> EbaCompanies { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<EbaGroup> EbaGroups { get; set; }
        public DbSet<AdPublisher> AdPublishers { get; set; }
        public DbSet<AdStatus> AdStatuses { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<ExperiencePeriod> ExperiencePeriods { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<MillitaryStatus> MillitaryStatuses { get; set; }
        public DbSet<PositionType> PositionTypes { get; set; }
        public DbSet<WorkModel> WorkModels { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<EbaDepartment> EbaDepartments { get; set; }
        public DbSet<Eba> Ebas { get; set; }
        public DbSet<Location> Locations{ get; set; }
        public DbSet<Profession> Professions{ get; set; }
        public DbSet<EbaUnit> EbaUnits { get; set; }
        public DbSet<SavedFiltersOfApprovedCandidateList> SavedFiltersOfApprovedCandidateList { get; set; }

        #endregion



    }
}
