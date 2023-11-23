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
        public ICollection<EbaStrKvpDto> PositionName { get; set; }
        public ICollection<EbaStrKvpDto> PositionTypeName { get; set; }
        public ICollection<EbaStrKvpDto> AdvertPublisherName { get; set; }
        public ICollection<EbaStrKvpDto> WorkTypeName { get; set; }
        public ICollection<EbaStrKvpDto> EducationLevelName { get; set; }
        public ICollection<EbaStrKvpDto> AdvertNumberId { get; set; }
    }
}
