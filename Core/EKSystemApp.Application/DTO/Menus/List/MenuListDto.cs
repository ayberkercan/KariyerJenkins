using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.DTO.Menus.List
{
    public class MenuListDto : BaseEntity
    {
        public int KeyId { get; set; }
        public string Label { get; set; }
        public string Icon { get; set; }
        public string RouterLink { get; set; }
        public List<Items>? Items { get; set; }
    }
}
