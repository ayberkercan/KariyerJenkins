using AutoMapper;
using EKSystemApp.Application.DTO.EBACompany;
using EKSystemApp.Application.Features.EBACompanies.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBACompanies.Handlers.List
{
    public class GetEBACompaniesQueryHandler : IRequestHandler<GetEBACompaniesQueryRequest, ICollection<EBACompanyDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<EBACompany> genericRepository;

        public GetEBACompaniesQueryHandler(IMapper mapper, IGenericRepository<EBACompany> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<EBACompanyDto>> Handle(GetEBACompaniesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.genericRepository.GetAllAsync();
            return this.mapper.Map<ICollection<EBACompanyDto>>(data);
        }
    }
}
