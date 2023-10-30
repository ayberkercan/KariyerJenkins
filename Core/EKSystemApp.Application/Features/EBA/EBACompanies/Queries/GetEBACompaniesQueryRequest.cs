using EKSystemApp.Application.DTO.Eba.EBACompany;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.EBACompanies.Queries
{
    public class GetEBACompaniesQueryRequest : IRequest<ICollection<EbaCompanyDto>>
    {

    }
}
