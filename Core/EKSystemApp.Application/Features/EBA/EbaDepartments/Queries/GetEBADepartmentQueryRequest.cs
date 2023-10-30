using EKSystemApp.Application.DTO.Eba.EBACompany;
using EKSystemApp.Application.DTO.Eba.EbaDepartment;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.EbaDepartments.Queries
{
    public class GetEBADepartmentQueryRequest : IRequest<ICollection<EbaDepartmentDto>>
    {

    }
}
