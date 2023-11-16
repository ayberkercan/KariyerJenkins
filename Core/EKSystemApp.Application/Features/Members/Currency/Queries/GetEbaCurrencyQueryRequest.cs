using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Currency.Queries
{
    public class GetEbaCurrencyQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
    }
}
