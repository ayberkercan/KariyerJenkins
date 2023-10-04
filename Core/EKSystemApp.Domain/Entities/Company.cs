using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public ICollection<AppUserCompany> AppUserCompanies { get; set; }
        public ICollection<CompanyMenu> CompanyMenues { get; set; }



    }
}
