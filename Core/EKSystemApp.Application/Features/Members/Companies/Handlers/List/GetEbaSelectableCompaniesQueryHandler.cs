using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Members.Cities.Queries;
using EKSystemApp.Application.Features.Members.Companies.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Member.Cities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.Companies.Handlers.List
{
    public class GetEbaSelectableCompaniesQueryHandler : IRequestHandler<GetEbaSelectableCompaniesQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;

        public GetEbaSelectableCompaniesQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaSelectableCompaniesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = ebaRepository.GetEbaSelectableCompanies().Result;

            return data;
        }
    }
}
