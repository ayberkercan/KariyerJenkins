using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Companies.Queries
{
    public class GetEbaSelectableCompaniesQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
    }
}
