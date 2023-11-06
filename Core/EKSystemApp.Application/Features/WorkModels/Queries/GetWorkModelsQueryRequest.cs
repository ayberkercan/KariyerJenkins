using EKSystemApp.Application.DTO.WorkModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.WorkModels.Queries
{
    public class GetWorkModelsQueryRequest:IRequest<ICollection<WorkModelDto>>
    {
    }
}
