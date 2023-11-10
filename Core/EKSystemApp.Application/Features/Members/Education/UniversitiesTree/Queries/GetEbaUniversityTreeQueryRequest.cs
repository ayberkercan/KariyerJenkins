using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Education.UniversitiesTree;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Education.UniversitiesTree.Queries
{
    public class GetEbaUniversityTreeQueryRequest : IRequest<ICollection<UniversityTreeDto>>
    {
        public int Key { get; set; }

        public GetEbaUniversityTreeQueryRequest(int key)
        {
            Key = key;
        }
    }
}
