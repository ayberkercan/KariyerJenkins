using AutoMapper;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Education.UniversitiesTree;
using EKSystemApp.Application.Features.Members.CountriesTree.Queries;
using EKSystemApp.Application.Features.Members.Education.UniversitiesTree.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Education.UniversitiesTree.Handlers.List
{
    public class GetEbaUniversityTreeQueryHandler : IRequestHandler<GetEbaUniversityTreeQueryRequest, ICollection<UniversityTreeDto>>
    {
        private readonly IEbaRepository _ebaRepository;

        public GetEbaUniversityTreeQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            _ebaRepository = ebaRepository;
        }

        public async Task<ICollection<UniversityTreeDto>> Handle(GetEbaUniversityTreeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _ebaRepository.GetUniversityTreeById(request.Key);

            return data;
        }
    }
}
