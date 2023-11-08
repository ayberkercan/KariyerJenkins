using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree
{
    public class GroupTreeDto
    {
        public string? UpKey { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public ICollection<DepartmentTreeDto>? Departments { get; set; }
    }
}
