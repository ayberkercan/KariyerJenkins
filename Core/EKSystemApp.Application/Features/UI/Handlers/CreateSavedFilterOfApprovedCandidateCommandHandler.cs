using AutoMapper;
using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using EKSystemApp.Application.Features.Adverts.Commands.Create;
using EKSystemApp.Application.Features.UI.Commands.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Domain.Entities.UI.SavedFilters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.UI.Handlers
{
    public class CreateSavedFilterOfApprovedCandidateCommandHandler : IRequestHandler<CreateSavedFilterOfApprovedCandidateCommandRequest, SavedFiltersOfApprovedCandidateListDto>
    {
        private readonly IGenericRepository<SavedFiltersOfApprovedCandidateList> repository;
        private readonly IMapper mapper;

        public CreateSavedFilterOfApprovedCandidateCommandHandler(IGenericRepository<SavedFiltersOfApprovedCandidateList> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<SavedFiltersOfApprovedCandidateListDto> Handle(CreateSavedFilterOfApprovedCandidateCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedData = mapper.Map<SavedFiltersOfApprovedCandidateListDto, SavedFiltersOfApprovedCandidateList>(request.Request);
            await repository.CreateAsync(mappedData);

            return request.Request;
        }
    }
}
