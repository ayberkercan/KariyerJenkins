using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Application.DTO.Company.List;
using MediatR;

namespace EKSystemApp.Application.Features.Companies.Queries
{
    public class GetCompanyQueryRequest : IRequest<ICollection<CompaniesListDto>>
    {
    }
}
