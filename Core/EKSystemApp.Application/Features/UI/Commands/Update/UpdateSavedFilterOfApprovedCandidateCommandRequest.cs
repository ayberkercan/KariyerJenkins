using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using EKSystemApp.Application.DTO.UI.SavedFilters.Update;
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
        public UpdateSavedFiltersDto Request { get; set; }

        public UpdateSavedFilterOfApprovedCandidateCommandRequest(UpdateSavedFiltersDto request)
        {
            Request = request;
        }
    }
}
