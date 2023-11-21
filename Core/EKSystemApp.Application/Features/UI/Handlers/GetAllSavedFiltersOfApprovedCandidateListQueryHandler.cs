using AutoMapper;
using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using EKSystemApp.Application.Features.UI.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Domain.Entities.UI.SavedFilters;
using MediatR;
using Nest;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.UI.Handlers
{
    public class GetAllSavedFiltersOfApprovedCandidateListQueryHandler : IRequestHandler<GetAllSavedFiltersOfApprovedCandidateListQueryRequest, ICollection<SavedFiltersOfApprovedCandidateListDto>>
    {
        private readonly IGenericRepository<SavedFiltersOfApprovedCandidateList> repository;
        private readonly IMapper mapper;

        public GetAllSavedFiltersOfApprovedCandidateListQueryHandler(IGenericRepository<SavedFiltersOfApprovedCandidateList> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ICollection<SavedFiltersOfApprovedCandidateListDto>> Handle(GetAllSavedFiltersOfApprovedCandidateListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await repository.GetAllAsync()).Where(x=>x.Owner == request.Request.Owner).ToList();
            return mapper.Map<ICollection<SavedFiltersOfApprovedCandidateListDto>>(data);
        }
    }
}
