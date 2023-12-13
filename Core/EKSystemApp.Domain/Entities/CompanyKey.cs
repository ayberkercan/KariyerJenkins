using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities
{
    public class CompanyKey : BaseEntity
    {
        public string CompaniesKey { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
