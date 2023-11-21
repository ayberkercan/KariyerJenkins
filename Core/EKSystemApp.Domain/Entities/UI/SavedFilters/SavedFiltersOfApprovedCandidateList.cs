using EKSystemApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.UI.SavedFilters
{
    public class SavedFiltersOfApprovedCandidateList : BaseEntity
    {
        public string Owner { get; set; }
        public string Caption { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? BackedUpCaption { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CandidateStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? FullName { get; set; }
        public string? ProvinceName { get; set; }
        public string? CityName { get; set; }
        public string? DrivingLicenseName { get; set; }
        public string? EducationLevelName { get; set; }
        public string? EducationDepartmentName { get; set; }
        public string? ForeignLanguageName { get; set; }
        public string? ForeignLanguageLevelName { get; set; }
        public string? ExperiencedProfessionName { get; set; }
        public string? ExperiencedDepartmentName { get; set; }
        public string? ExperienceTotalRange { get; set; }
        public string? PositionName { get; set; }
        public string? PositionTypeName { get; set; }
        public string? LocationName { get; set; }
        public string? AdvertNumberId { get; set; }
    }
}
