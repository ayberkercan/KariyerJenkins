using EKSystemApp.Application.DTO.Eba.EbaLocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.EbaLocations.Queries
{
    public class GetEbaLocationsQueryRequest:IRequest<ICollection<EbaLocationDto>>
    {

    }
}
