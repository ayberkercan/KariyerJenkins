using EKSystemApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Advert.List
{
    public class AdvertsDto:BaseEntity
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? PositionName { get; set; }
        public string? PositionTypeName { get; set; }
        public string? AdvertPublisherName { get; set; }
        public string? WorkTypeName { get; set; }
        public string? EducationLevelName { get; set; }
        public int? AdvertNumberId { get; set; }
    }
}
