using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Countries.Queries
{
    public class GetEbaCountryQueryRequest : IRequest<ICollection<ST_CountriesDto>>
    {
    }
}
