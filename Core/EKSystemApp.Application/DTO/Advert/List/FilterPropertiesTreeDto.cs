using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.PositionsTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Advert.List
{
    public class FilterPropertiesTreeDto
    {
        public ICollection<string> PositionName { get; set; }
        public ICollection<string> PositionTypeName { get; set; }
        public ICollection<string> AdvertPublisherName { get; set; }
        public ICollection<string> WorkTypeName { get; set; }
        public ICollection<string> EducationLevelName { get; set; }
        public ICollection<int> AdvertNumberId { get; set; }
    }
}
