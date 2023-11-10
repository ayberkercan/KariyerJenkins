using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Provinces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Provinces.Queries
{
    public class GetEbaProvinceQueryRequest : IRequest<ICollection<ST_ProvincesDto>>
    {
        public int upKey { get; set; }

        public GetEbaProvinceQueryRequest(int key)
        {
            upKey = key;
        }
    }
}
