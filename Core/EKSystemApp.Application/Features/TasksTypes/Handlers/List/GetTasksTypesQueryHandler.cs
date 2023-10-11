using AutoMapper;
using EKSystemApp.Application.DTO.Task.List;
using EKSystemApp.Application.Features.TasksTypes.Queries.List;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;

namespace EKSystemApp.Application.Features.TasksTypes.Handlers.List
{
    public class GetTasksTypesQueryHandler : IRequestHandler<GetTasksTypesQueryRequest, ICollection<TaskTypeDto>>
    {
        private readonly IGenericRepository<TaskType> repository;
        private readonly IMapper mapper;

        public GetTasksTypesQueryHandler(IGenericRepository<TaskType> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ICollection<TaskTypeDto>> Handle(GetTasksTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var data =await repository.GetAllAsync();
            return mapper.Map<ICollection<TaskTypeDto>>(data);
        }
    }
}
