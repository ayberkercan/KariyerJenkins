using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class EducationLevel : BaseEntity
    {
        public string EducationLevelName { get; set; }
    }
}
