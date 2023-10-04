using EKSystemApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Admin.FilterAppList
{
    public class AppCandidateFilter:BaseEntity
    {
        public Guid AppUserId  { get; set; }
        public AppUser AppUser { get; set; }

    }
}
