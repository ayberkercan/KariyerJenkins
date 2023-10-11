using EKSystemApp.Application.DTO.EBACompany;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBACompanies.Queries
{
    public class GetEBACompaniesQueryRequest:IRequest<ICollection<EBACompanyDto>>
    {

    }
}
