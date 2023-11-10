using EKSystemApp.Application.DTO.Member.Cities;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Provinces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Cities.Queries
{
    public class GetEbaCityQueryRequest : IRequest<ICollection<ST_CitiesDto>>
    {
        public int upKey { get; set; }

        public GetEbaCityQueryRequest(int key)
        {
            upKey = key;
        }
    }
}
