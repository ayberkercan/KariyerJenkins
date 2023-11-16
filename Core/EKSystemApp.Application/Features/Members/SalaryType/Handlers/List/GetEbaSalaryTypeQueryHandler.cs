using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Members.Currency.Queries;
using EKSystemApp.Application.Features.Members.SalaryType.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Member.Currency;
using EKSystemApp.Domain.Entities.Member.SalaryType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.SalaryType.Handlers.List
{
    public class GetEbaSalaryTypeQueryHandler : IRequestHandler<GetEbaSalaryTypeQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<SalaryTypes> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaSalaryTypeQueryHandler(IEbaGenericRepository<SalaryTypes> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaSalaryTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.ORDER);

            return _mapper.Map<IEnumerable<SalaryTypes>, ICollection<EbaStrKvpDto>>(data);
        }
    }
}
