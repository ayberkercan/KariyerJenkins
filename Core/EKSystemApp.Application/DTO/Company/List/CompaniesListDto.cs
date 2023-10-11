using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.DTO.Company.List
{
    public class CompaniesListDto : BaseEntity
    {
        public string CompanyName { get; set; }
        public Guid? MenuId { get; set; }
        public Menu? Menu { get; set; }
        public ICollection<AppUserCompany> AppUserCompanies { get; set; }
    }
}
