using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Application.DTO.Menus.List
{
    public class MenuListDto : BaseEntity
    {
        public string? Name { get; set; }
        public string? RouterLink { get; set; }
        public string? RouterIcon { get; set; }

    }
}
