using AutoMapper;
using EKSystemApp.Application.DTO.Member.Countries;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Education.Departments;
using EKSystemApp.Application.DTO.Member.Education.Universities;
using EKSystemApp.Application.Features.Members.CountriesTree.Queries;
using EKSystemApp.Application.Features.Members.Education.Universities.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Member.Countries;
using EKSystemApp.Domain.Entities.Member.Education.Departments;
using EKSystemApp.Domain.Entities.Member.Education.Universities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Education.Universities.Handlers.List
{
    public class GetEbaUniversityQueryHandler : IRequestHandler<GetEbaUniversityQueryRequest, ICollection<ST_UniversitiesDto>>
    {
        private readonly IEbaGenericRepository<ST_Universities> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaUniversityQueryHandler(IEbaGenericRepository<ST_Universities> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<ST_UniversitiesDto>> Handle(GetEbaUniversityQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.Value);

            return _mapper.Map<IEnumerable<ST_Universities>, ICollection<ST_UniversitiesDto>>(data);
        }
    }
}
