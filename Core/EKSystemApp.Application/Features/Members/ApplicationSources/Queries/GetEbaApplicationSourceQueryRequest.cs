using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.ApplicationSources.Queries
{
    public class GetEbaApplicationSourceQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
    }
}
