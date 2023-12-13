using AutoMapper;
using EKSystemApp.Application.DTO.WorkStepsManager.List;
using EKSystemApp.Application.Features.WorkStepManager.Queries.List;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.WorkStepManager;
using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Handlers.List
{
    public class GetAllWorkStepManagerCommandHandler : IRequestHandler<AllWorkStepManagerQueryRequest, ICollection<WorkStepManagerListDto>>
    {
        private readonly IGenericRepository<WorksStepManager> repository;
        private readonly IMapper mapper;

        public GetAllWorkStepManagerCommandHandler(IGenericRepository<WorksStepManager> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ICollection<WorkStepManagerListDto>> Handle(AllWorkStepManagerQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllAsync();
            return this.mapper.Map<ICollection<WorkStepManagerListDto>>(data);
        }
    }
}
