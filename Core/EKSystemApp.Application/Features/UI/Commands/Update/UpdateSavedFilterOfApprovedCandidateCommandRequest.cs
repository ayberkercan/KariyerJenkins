using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.UI.Commands.Update
{
    public class UpdateSavedFilterOfApprovedCandidateCommandRequest : IRequest<SavedFiltersOfApprovedCandidateListDto>
    {
        public SavedFiltersOfApprovedCandidateListDto Request { get; set; }

        public UpdateSavedFilterOfApprovedCandidateCommandRequest(SavedFiltersOfApprovedCandidateListDto request)
        {
            Request = request;
        }
    }
}
