using EKSystemApp.Application.DTO.Member.CountriesTree;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.CountriesTree.Queries
{
    public class GetEbaCountryTreeQueryRequest : IRequest<ICollection<CountryTreeDto>>
    {
        public int Key { get; set; }

        public GetEbaCountryTreeQueryRequest(int key)
        {
            Key = key;
        }
    }
}
