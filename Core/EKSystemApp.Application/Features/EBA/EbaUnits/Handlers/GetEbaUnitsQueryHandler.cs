using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaDepartment;
using EKSystemApp.Application.DTO.Eba.EbaGroup;
using EKSystemApp.Application.DTO.Eba.EbaUnit;
using EKSystemApp.Application.Features.EBA.EbaUnits.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.EbaUnits.Handlers
{
    public class GetEbaUnitsQueryHandler : IRequestHandler<GetEbaUnitsQueryRequest, ICollection<EbaUnitDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<EbaUnit> genericRepository;

        public GetEbaUnitsQueryHandler(IMapper mapper, IGenericRepository<EbaUnit> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<EbaUnitDto>> Handle(GetEbaUnitsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<EbaUnitDto>>(data);
        }
    }
}
