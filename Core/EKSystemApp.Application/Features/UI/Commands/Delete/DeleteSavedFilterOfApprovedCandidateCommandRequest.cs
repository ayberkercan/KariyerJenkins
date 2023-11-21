using EKSystemApp.Application.DTO.UI.SavedFilters.Delete;
using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using EKSystemApp.Application.DTO.UI.SavedFilters.Update;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.UI.Commands.Delete
{
    public class DeleteSavedFilterOfApprovedCandidateCommandRequest : IRequest<SavedFiltersOfApprovedCandidateListDto>
    {
        public DeleteSavedFiltersDto Request { get; set; }

        public DeleteSavedFilterOfApprovedCandidateCommandRequest(DeleteSavedFiltersDto request)
        {
            Request = request;
        }
    }
}
