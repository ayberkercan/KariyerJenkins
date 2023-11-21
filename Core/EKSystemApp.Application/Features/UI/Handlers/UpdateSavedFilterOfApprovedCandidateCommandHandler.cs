using AutoMapper;
using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using EKSystemApp.Application.Features.UI.Commands.Create;
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
    public class UpdateSavedFilterOfApprovedCandidateCommandHandler : IRequestHandler<UpdateSavedFilterOfApprovedCandidateCommandRequest, SavedFiltersOfApprovedCandidateListDto>
    {
        private readonly IGenericRepository<SavedFiltersOfApprovedCandidateList> repository;
        private readonly IMapper mapper;

        public UpdateSavedFilterOfApprovedCandidateCommandHandler(IGenericRepository<SavedFiltersOfApprovedCandidateList> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<SavedFiltersOfApprovedCandidateListDto> Handle(UpdateSavedFilterOfApprovedCandidateCommandRequest request, CancellationToken cancellationToken)
        {
            var data = repository.GetByIdAsync(request.Request.Id).Result;
            
            if (data != null)
            {
                data.BackedUpCaption = data.Caption;
                data.Caption = request.Request.Caption;
                data.UpdatedDate = DateTime.Now;

                await repository.UpdateAsync(data);
            }

            return mapper.Map<SavedFiltersOfApprovedCandidateList, SavedFiltersOfApprovedCandidateListDto>(data);
        }
    }
}
