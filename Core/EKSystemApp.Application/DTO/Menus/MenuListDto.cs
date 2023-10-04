using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Application.DTO.Menus
{
    public class MenuListDto : BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
