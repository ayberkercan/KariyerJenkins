using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.DTO.Advert.List
{
    public class AdvertListDto : BaseEntity
    {
        public string? WorkDefination { get; set; }
        public string? Brand { get; set; }
        public string? PublicQuality { get; set; }
        public string? PositionValue { get; set; }
        public string? PositionKey { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Logo { get; set; } = null;
        public string? PeriotNumberId { get; set; }
        public string? AdvertNumberId { get; set; }
        public string? TaskTypeName { get; set; }
        public string? CompanyName { get; set; }
        public string? OrganizationName { get; set; }
        public string? GroupName { get; set; }
        public string? DepartmentName { get; set; }
        public string? UnitName { get; set; }
        public string? WorkTypeName { get; set; }
        public string? PositionTypeName { get; set; }
        public string? WorkModelName { get; set; }
        public string? LocationName { get; set; }
        public string? EducationLevelName { get; set; }
        public string? MillitaryStatusName { get; set; }
        public string? JobCategoryName { get; set; }
        public string? AdvertStatusName { get; set; }
        public string? AdvertPublisherName { get; set; }
        public string? WorkCategory { get; set; }
        public string? ExperiencePeriod { get; set; }
        public string? EbaProcessId { get; set; }
        public List<AdvertAdQuestions> AdvertAdQuestions { get; set; }
        public List<AdvertForeignLanguages> AdvertForeignLanguages { get; set; }
        public List<string> AdvertSkillAndExpertises { get; set; }
    }
} 