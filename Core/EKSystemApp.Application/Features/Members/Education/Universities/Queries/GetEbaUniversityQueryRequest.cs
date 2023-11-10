using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.Education.Departments;
using EKSystemApp.Application.DTO.Member.Education.Universities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Education.Universities.Queries
{
    public class GetEbaUniversityQueryRequest : IRequest<ICollection<ST_UniversitiesDto>>
    {
    }
}
