using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Application.DTO.TaskType;
using MediatR;

namespace EKSystemApp.Application.Features.TasksTypes.Queries.List
{
    public class GetTasksTypesQueryRequest : IRequest<ICollection<TaskTypeDto>>
    {

    }
}
