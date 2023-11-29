using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Domain
{
    public class CompanyKey:BaseEntity
    {
        public string CompaniesKey { get; set; }
        public Guid Id { get; set; }
        public Company Company { get; set; }
    }
}
