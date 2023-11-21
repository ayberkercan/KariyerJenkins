using EKSystemApp.Application.DTO.Advert.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.UI.Queries
{
    public class CheckAllSavedFiltersOfApprovedCandidateListQueryRequest
    {
        public string Owner { get; set; }

        public CheckAllSavedFiltersOfApprovedCandidateListQueryRequest(string owner)
        {
            Owner = owner;
        }
    }
}
