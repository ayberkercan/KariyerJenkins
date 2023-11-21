using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.UI.SavedFilters.Update
{
    public class UpdateSavedFiltersDto
    {
        public Guid Id { get; set; }
        public string Owner { get; set; }
        public string Caption { get; set; }
    }
}
