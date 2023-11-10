using AutoMapper;
using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Education.Departments;
using EKSystemApp.Application.Features.Members.CountriesTree.Queries;
using EKSystemApp.Application.Features.Members.Education.Departments.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Member.Cities;
using EKSystemApp.Domain.Entities.Member.Countries;
using EKSystemApp.Domain.Entities.Member.Education.Departments;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Education.Departments.Handlers.List
{
    public class GetEbaEducationDepartmentQueryHandler : IRequestHandler<GetEbaEducationDeparmentQueryRequest, ICollection<ST_DepartmentsDto>>
    {
        private readonly IEbaGenericRepository<ST_Departments> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaEducationDepartmentQueryHandler(IEbaGenericRepository<ST_Departments> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<ST_DepartmentsDto>> Handle(GetEbaEducationDeparmentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).Where(x => x.UpKey == request.upKey).OrderBy(x => x.Value);

            return _mapper.Map<IEnumerable<ST_Departments>, ICollection<ST_DepartmentsDto>>(data);
        }
    }
}
