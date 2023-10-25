using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string RouterLink { get; set; }
        public string RouterIcon { get; set; }
        public ICollection<AppUserMenu> AppUserMenus { get; set; }

    }
}

