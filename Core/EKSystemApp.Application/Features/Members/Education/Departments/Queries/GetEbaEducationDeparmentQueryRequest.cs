using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.Education.Departments;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Education.Departments.Queries
{
    public class GetEbaEducationDeparmentQueryRequest : IRequest<ICollection<ST_DepartmentsDto>>
    {
        public int upKey { get; set; }

        public GetEbaEducationDeparmentQueryRequest(int key)
        {
            upKey = key;
        }
    }
}
