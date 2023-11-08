using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class GetEbaOrganizationTreeQueryRequest : IRequest<ICollection<OrganizationTreeDto>>
    {
        public string Key { get; set; }

        public GetEbaOrganizationTreeQueryRequest(string key)
        {
            Key = key;
        }
    }
}
