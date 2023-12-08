using AutoMapper;
using EKSystemApp.Application.DTO.WorkStepsManager.Create;
using EKSystemApp.Application.Features.WorkStepManager.Commands.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.WorkStepManager;
using MediatR;

namespace EKSystemApp.Application.Features.WorkStepManager.Handlers.Create
{
    public class CreateWorkStepManagerCommandHandler : IRequestHandler<CreateWorkStepManagerCommandRequest, WorkStepManagerCreateDto>
    {
        private readonly IGenericRepository<WorksStepManager> repository;
        private readonly IMapper mapper;

        public CreateWorkStepManagerCommandHandler(IGenericRepository<WorksStepManager> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<WorkStepManagerCreateDto> Handle(CreateWorkStepManagerCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = new WorksStepManager
            {
                Defination = request.Defination,
                Image = request.Image,
                WorkSteps = request.WorkSteps,
                WorkStepsTitle = request.WorkStepsTitle
            };
            var result = await this.repository.CreateAsync(entity);
            return this.mapper.Map<WorkStepManagerCreateDto>(result);
        }
    }
}
