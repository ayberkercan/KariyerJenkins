using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;
using Nest;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class GetAllAvailableFilterPropertiesQueryHandler : IRequestHandler<GetAllAvailableFilterPropertiesQueryRequest, FilterPropertiesTreeDto>
    {
        private readonly IGenericRepository<AdvertCreate> advertRepository;
        private readonly IMapper mapper;

        public GetAllAvailableFilterPropertiesQueryHandler(IGenericRepository<AdvertCreate> advertRepository, IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.mapper = mapper;
        }

        public async Task<FilterPropertiesTreeDto> Handle(GetAllAvailableFilterPropertiesQueryRequest request, CancellationToken cancellationToken)
        {
            var advertList = advertRepository.GetAllAsync().Result.ToList();

            if (advertList != null)
            {
                return new FilterPropertiesTreeDto()
                {
                    PositionName = advertList.Select(x => x.PositionName).Distinct().ToList(),
                    PositionTypeName = advertList.Select(x => x.PositionTypeName).Distinct().ToList(),
                    AdvertPublisherName = advertList.Select(x => x.AdvertPublisherName!).Distinct().ToList(),
                    WorkTypeName = advertList.Select(x => x.WorkTypeName).Distinct().ToList(),
                    EducationLevelName = advertList.Select(x => x.EducationLevelName).Distinct().ToList(),
                    AdvertNumberId = advertList.Select(x => x.AdvertNumberId).Distinct().ToList(),
                };
            }
            else
            {
                return this.mapper.Map<FilterPropertiesTreeDto>(advertList);
            }
          
        }
    }
}
