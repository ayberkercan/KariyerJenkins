using EKSystemApp.Application.DTO.Advert.List;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Adverts.Queries
{
    public class GetAllAvailableFilterPropertiesQueryRequest : IRequest<FilterPropertiesTreeDto>
    {
    }
}
