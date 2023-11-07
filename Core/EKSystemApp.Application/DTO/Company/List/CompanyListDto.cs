using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Application.DTO.Company.List
{
    public  class CompanyListDto : BaseEntity
    {
        public string CompanyName { get; set; }
    }
}
