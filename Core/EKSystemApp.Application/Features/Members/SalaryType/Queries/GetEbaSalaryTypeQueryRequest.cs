using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.SalaryType.Queries
{
    public class GetEbaSalaryTypeQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
    }
}
