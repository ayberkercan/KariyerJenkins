using AutoMapper;
using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using EKSystemApp.Application.Features.UI.Commands.Create;
using EKSystemApp.Application.Features.UI.Commands.Delete;
using EKSystemApp.Application.Features.UI.Commands.Update;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.UI.SavedFilters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.UI.Handlers
{
    public class DeleteSavedFilterOfApprovedCandidateCommandHandler : IRequestHandler<DeleteSavedFilterOfApprovedCandidateCommandRequest, SavedFiltersOfApprovedCandidateListDto>
    {
        private readonly IGenericRepository<SavedFiltersOfApprovedCandidateList> repository;
        private readonly IMapper mapper;

        public DeleteSavedFilterOfApprovedCandidateCommandHandler(IGenericRepository<SavedFiltersOfApprovedCandidateList> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<SavedFiltersOfApprovedCandidateListDto> Handle(DeleteSavedFilterOfApprovedCandidateCommandRequest request, CancellationToken cancellationToken)
        {
            var data = repository.GetByIdAsync(request.Request.Id).Result;

            if (data != null && request.Request.Owner == data.Owner)
            {
                await repository.Remove(data);
                
                data = new SavedFiltersOfApprovedCandidateList();
            }

            return mapper.Map<SavedFiltersOfApprovedCandidateList, SavedFiltersOfApprovedCandidateListDto>(data);
        }
    }
}
