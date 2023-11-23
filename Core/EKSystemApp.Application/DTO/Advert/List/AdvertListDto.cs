using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Advert.List
{
    public class AdvertListDto
    {
        public string WorkDefination { get; set; }
        public string PublicQuality { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PeriotNumberId { get; set; }
        public int AdvertNumberId { get; set; }
        public string PositionName { get; set; }
        public string? Logo { get; set; }
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
        public string ExperiencePeriod { get; set; }
        public string MillitaryStatusName { get; set; }
        public string AdvertStatusName { get; set; }
        public string AdvertPublisherName { get; set; }
        public string Brand { get; set; }
        public string WorkCategory { get; set; }
        public int EbaProcessId { get; set; }
    }
} 