using EKSystemApp.Application.DTO.ForignLanguages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.ForignLanguages.Queries
{
    public class GetForignLanguagesQueryRequest:IRequest<ICollection<ForignLanguageDto>>
    {
    }
}
