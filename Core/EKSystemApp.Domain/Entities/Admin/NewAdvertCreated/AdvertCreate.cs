using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Domain.Entities.Admin.NewAdvertCreated
{
    public class AdvertCreate : BaseEntity
    {
        public ICollection<Position> Positions { get; set; }
        public ICollection<TaskType> TasksTypes { get; set; }
        public ICollection<EBACompany> EBACompanies { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<Unit> Units { get; set; }
        public ICollection<WorkType> WorkTypes { get; set; }
        public ICollection<PositionType> PositionTypes { get; set; }
        public ICollection<WorkModel> WorkModels { get; set; }
        public ICollection<Locaiton> Locaitons { get; set; }
        public ICollection<EducationLevel> EducationLevels { get; set; }
        public ICollection<ExperiencePeriod> ExperiencePeriods { get; set; }
        public ICollection<MillitaryStatus> MillitaryStatuses { get; set; }
        public ICollection<ForignLanguage> ForignLanguages { get; set; }
        public ICollection<JobCategory> JobCategories { get; set; }
        public ICollection<AdStatus> AdStatuses { get; set; }
        public ICollection<AdPublisher> AdPublishers { get; set; }
        public ICollection<AdQuestion> AdQuestions { get; set; }
        public string WorkDefination { get; set; }
        public string PublicQuality { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Logo { get; set; }
        public int PeriotNumberId { get; set; }
        public int AdwertNumberId { get; set; }
    }
}
