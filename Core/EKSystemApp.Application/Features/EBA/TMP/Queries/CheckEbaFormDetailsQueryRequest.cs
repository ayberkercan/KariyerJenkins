using EKSystemApp.Application.DTO.Jwt;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class CheckEbaFormDetailsQueryRequest// : IRequest<buraya yazılacak>
    {
        public int ProcessId { get; set; }
    }
}
