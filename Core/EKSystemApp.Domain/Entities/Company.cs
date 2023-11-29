using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public ICollection<AppUserCompany> AppUserCompanies { get; set; }
        public ICollection<CompanyKey> CompanyKeys { get; set; }


    }
}
