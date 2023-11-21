using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using MediatR;

namespace EKSystemApp.Application.Features.UI.Queries
{
    public class GetAllSavedFiltersOfApprovedCandidateListQueryRequest : IRequest<ICollection<SavedFiltersOfApprovedCandidateListDto>>
    {
        public CheckAllSavedFiltersOfApprovedCandidateListQueryRequest Request { get; set; }

        public GetAllSavedFiltersOfApprovedCandidateListQueryRequest(CheckAllSavedFiltersOfApprovedCandidateListQueryRequest request)
        {
            Request = request;
        }
    }
}
