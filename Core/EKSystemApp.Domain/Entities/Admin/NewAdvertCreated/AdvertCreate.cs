using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
namespace EKSystemApp.Domain.Entities.Admin.NewAdvertCreated
{
    public class AdvertCreate : BaseEntity
    {
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string? WorkDefination { get; set; }
        public ICollection<Brand>? Brands { get; set; }
        public string? PublicQuality { get; set; }
        public ICollection<Position>? Positions { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<Logo>? Logos { get; set; } = null;
        public int? PeriotNumberId { get; set; }
        public int? AdvertNumberId { get; set; }
        public ICollection<Organization>? Organizations { get; set; }
        public ICollection<Group>? Groups { get; set; }
        public ICollection<Department>? Departments { get; set; }
        public ICollection<Unit>? Units { get; set; }
        public ICollection<WorkType>? WorkTypes { get; set; }
        public ICollection<PositionType>? PositionTypes { get; set; }
        public ICollection<WorkModel>? WorkModels { get; set; }
        public ICollection<Location>? Locations { get; set; }
        public ICollection<EducationLevel>? EducationLevels { get; set; }
        public ICollection<MillitaryStatus>? MillitaryStatuses { get; set; }
        public ICollection<AdvertStatus>? AdvertStatuses { get; set; }
        public string? AdvertPublisherName { get; set; }
        public ICollection<AdvertSkillAndExpertises>? AdvertSkillAndExpertises { get; set; }
        public ICollection<AdvertForeignLanguages>? AdvertForeignLanguages { get; set; }
        public ICollection<AdvertAdQuestions>? AdvertAdQuestions { get; set; }
        public ICollection<WorkCategory>? WorkCategories { get; set; }
        public ICollection<ExperiencePeriod>? ExperiencePeriods { get; set; }
        public string? EbaProcessId { get; set; }
        public string? ProcessNumber { get; set; }
       
    }
}
