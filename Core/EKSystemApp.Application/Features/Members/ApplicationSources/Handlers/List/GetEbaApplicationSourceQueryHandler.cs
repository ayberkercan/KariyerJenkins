using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Members.ApplicationSources.Queries;
using EKSystemApp.Application.Features.Members.Currency.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Member.Currency;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Members.ApplicationSources.Handlers.List
{
    public class GetEbaApplicationSourceQueryHandler : IRequestHandler<GetEbaApplicationSourceQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaRepository ebaRepository;

        public GetEbaApplicationSourceQueryHandler(IEbaRepository ebaRepository)
        {
            this.ebaRepository = ebaRepository;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaApplicationSourceQueryRequest request, CancellationToken cancellationToken)
        {
            var data = ebaRepository.GetEbaApplicationSources().Result;

            return data;
        }
    }
}
