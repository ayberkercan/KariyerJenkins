using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities
{
    public class AppUserCompany
    {
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; } 
        public Guid CompanyId { get; set; }
        public Company Company { get; set; } 

    }
}
