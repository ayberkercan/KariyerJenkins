using AutoMapper;
using EKSystemApp.Application.DTO.WorkStepsManager.List;
using EKSystemApp.Application.Features.WorkStepManager.Queries.List;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.WorkStepManager;
using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Handlers.List
{
    public class GetByIdWorkStepManagerCommandHandler : IRequestHandler<WorkStepManagerQueryRequest, WorkStepManagerListDto>
    {
        private readonly IGenericRepository<WorksStepManager> repository;
        private readonly IMapper mapper;
        public async Task<WorkStepManagerListDto> Handle(WorkStepManagerQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<WorkStepManagerListDto>(data);
        }
    }
}
