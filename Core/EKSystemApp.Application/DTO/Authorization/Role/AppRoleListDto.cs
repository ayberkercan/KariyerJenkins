using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Application.DTO.Authorization.Role
{
    public class AppRoleListDto : BaseEntity
    {
        public string? Name { get; set; }
        public string? Defination { get; set; }
        public string? NormalizedName { get; set; }

    }
}
