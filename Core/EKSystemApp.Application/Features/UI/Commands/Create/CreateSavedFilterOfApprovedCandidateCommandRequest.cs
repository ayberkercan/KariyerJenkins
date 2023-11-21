using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.UI.Commands.Create
{
    public class CreateSavedFilterOfApprovedCandidateCommandRequest : IRequest<SavedFiltersOfApprovedCandidateListDto>
    {
        public SavedFiltersOfApprovedCandidateListDto Request { get; set; }

        public CreateSavedFilterOfApprovedCandidateCommandRequest(SavedFiltersOfApprovedCandidateListDto request) 
        {
            Request = request;
        }
    }
}
