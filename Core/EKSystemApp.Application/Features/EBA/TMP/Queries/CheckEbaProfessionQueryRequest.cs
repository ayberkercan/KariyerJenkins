using EKSystemApp.Application.DTO.Eba.EbaUnit;
using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class CheckEbaProfessionQueryRequest : IRequest<ICollection<EbaKvpDto>>
    {
        public string orgId { get; set; }
        public string? groupId { get; set; }
        public string? departmentId { get; set; }
        public string? unitId { get; set; }
    }
}
