using AutoMapper;
using EKSystemApp.Application.DTO.AdStatus;
using EKSystemApp.Application.DTO.ForignLanguages;
using EKSystemApp.Application.Features.ForignLanguages.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.ForignLanguages.Handler.List
{
    public class GetForignLanguagesQueryHandler : IRequestHandler<GetForignLanguagesQueryRequest, ICollection<ForignLanguageDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<AdvertForeignLanguages> genericRepository;
        public GetForignLanguagesQueryHandler(IMapper mapper, IGenericRepository<AdvertForeignLanguages> genericRepository) 
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<ForignLanguageDto>> Handle(GetForignLanguagesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<ForignLanguageDto>>(data); ;
        }
    }
}
