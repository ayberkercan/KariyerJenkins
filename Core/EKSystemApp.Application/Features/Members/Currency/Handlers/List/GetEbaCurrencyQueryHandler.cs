using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.Features.Members.CountriesTree.Queries;
using EKSystemApp.Application.Features.Members.Currency.Queries;
using EKSystemApp.Application.Features.Members.Provinces.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Member.Currency;
using EKSystemApp.Domain.Entities.Member.Provinces;
using MediatR;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Currency.Handlers.List
{
    public class GetEbaCurrencyQueryHandler : IRequestHandler<GetEbaCurrencyQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<Currencies> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaCurrencyQueryHandler(IEbaGenericRepository<Currencies> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaCurrencyQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.ORDER);

            return _mapper.Map<IEnumerable<Currencies>, ICollection<EbaStrKvpDto>>(data);
        }
    }
}
