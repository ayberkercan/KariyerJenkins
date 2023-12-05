using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities
{
    public class AppUserItem
    {
        public Guid AppUserId { get; set; }
        public AppUser AppUser{ get; set; }
        public Guid ItemId { get; set; }
        public Items Items { get; set; }
    }
}
