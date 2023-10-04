using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities
{
    public class CompanyMenu
    {
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public Guid MenuId{ get; set; }
        public Menu Menu { get; set; }
    }
}
