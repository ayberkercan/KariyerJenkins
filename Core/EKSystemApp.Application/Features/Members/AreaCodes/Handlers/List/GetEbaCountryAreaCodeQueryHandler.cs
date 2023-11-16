using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Members.AreaCodes.Queries;
using EKSystemApp.Application.Features.Members.Countries.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Member.AreaCodes;
using EKSystemApp.Domain.Entities.Member.Countries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.AreaCodes.Handlers.List
{
    public class GetEbaCountryAreaCodeQueryHandler : IRequestHandler<GetEbaCountryAreaCodeQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<CountryAreaCodes> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaCountryAreaCodeQueryHandler(IEbaGenericRepository<CountryAreaCodes> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaCountryAreaCodeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.CountryCode.Split("")[0]);

            return _mapper.Map<IEnumerable<CountryAreaCodes>, ICollection<EbaStrKvpDto>>(data);
        }
    }
}
