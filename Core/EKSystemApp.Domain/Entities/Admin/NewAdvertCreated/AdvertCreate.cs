﻿using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Domain.Entities.Admin.NewAdvertCreated
{
    public class AdvertCreate : BaseEntity
    {
        public string WorkDefination { get; set; }
        public string PublicQuality { get; set; }
        public string PositionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Logo { get; set; } = null;
        public int PeriotNumberId { get; set; }
        public int AdwertNumberId { get; set; }
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
        public string? ExperiencePeriodName { get; set; }
        public string MillitaryStatusName { get; set; }
        public string? JobCategoryName { get; set; }
        public string? AddStatusName { get; set; }
        public string? AddPublisherName { get; set; }
        public string? SkillAndExpertises { get; set; }
        public string? ForeignLanguages { get; set; }
        public string? AddQuestions { get; set; }
        //public ICollection<AdvertSkillAndExpertises> SkillAndExpertises { get; set; }
        //public ICollection<AdvertForignLanguages> ForeignLanguages { get; set; }
        //public ICollection<AdvertAdQuestions> AddQuestions { get; set; }
    }
}
