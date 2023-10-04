using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Member
{
    public class SavedAdvert:BaseEntity
    {
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string AdvertStatus { get; set; }
    }
}
