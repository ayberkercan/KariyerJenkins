using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Domain.Entities.Admin.NewAdvertCreated
{
    public class AdvertCreate : BaseEntity
    {
        public string WorkDefination { get; set; }

        public string Brand { get; set; }
        public string PublicQuality { get; set; }
        public string PositionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Logo { get; set; } = null;
        public int PeriotNumberId { get; set; }
        public int AdvertNumberId { get; set; }
        public string? TaskTypeName { get; set; }
        public string? CompanyName { get; set; }
        public string OrganizationName { get; set; }
        public string GroupName { get; set; }
        public string DepartmentName { get; set; }
        public string UnitName { get; set; }
        public string WorkTypeName { get; set; }                                          
        public string PositionTypeName { get; set; }
        public string WorkModelName { get; set; }
        public string LocationName { get; set; }
        public string EducationLevelName { get; set; }
        public string MillitaryStatusName { get; set; }
        public string? JobCategoryName { get; set; }
        public string? AdvertStatusName { get; set; }
        public string? AdvertPublisherName { get; set; }
        public ICollection<AdvertSkillAndExpertises> AdvertSkillAndExpertises { get; set; }
        public ICollection<AdvertForignLanguages> AdvertForignLanguages { get; set; }
        public ICollection<AdvertAdQuestions> AdvertAdQuestions { get; set; }
        public string? WorkCategory { get; set; }
        public string? ExperiencePeriod { get; set; }
        public string? EbaProcessId { get; set; }
    }
}
