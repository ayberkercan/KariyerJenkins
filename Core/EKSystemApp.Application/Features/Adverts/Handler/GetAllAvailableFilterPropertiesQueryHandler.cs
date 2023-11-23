using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Domain.Entities.eBA;
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
        private readonly IEbaGenericRepository<EducationStatus> educationLevelRepository;
        private readonly IEbaGenericRepository<Titles> positionRepository;
        private readonly IEbaGenericRepository<WorkingType> workTypeRepository;
        private readonly IMapper mapper;

        public GetAllAvailableFilterPropertiesQueryHandler(
            IGenericRepository<AdvertCreate> advertRepository,
            IEbaGenericRepository<EducationStatus> educationLevelRepository,
            IEbaGenericRepository<Titles> positionRepository,
            IEbaGenericRepository<WorkingType> workTypeRepository,
            IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.educationLevelRepository = educationLevelRepository;
            this.positionRepository = positionRepository;
            this.workTypeRepository = workTypeRepository;
            this.mapper = mapper;
        }

        public async Task<FilterPropertiesTreeDto> Handle(GetAllAvailableFilterPropertiesQueryRequest request, CancellationToken cancellationToken)
        {
            var advertList = advertRepository.GetAllAsync().Result.ToList();
            var positionTypeList = this.mapper.Map<List<EbaStrKvpDto>>(advertList.Select(x => x.PositionTypeName).Distinct().ToList()).OrderBy(x => x.Key).ToList();
            var advertPublisherList = this.mapper.Map<List<EbaStrKvpDto>>(advertList.Select(x => x.AdvertPublisherName).Distinct().ToList()).OrderBy(x => x.Key).ToList();
            var educationLevelList = this.mapper.Map<List<EbaStrKvpDto>>((await educationLevelRepository.GetAllAsync())
                        .Select(item =>
                        {
                            item.TANIM = item.TANIM.Split('-')[1];
                            return item;
                        })
                        .ToList()).OrderBy(x => x.Key).ToList();
            var positionList = this.mapper.Map<List<EbaStrKvpDto>>((await positionRepository.GetAllAsync())).OrderBy(x => x.Value).ToList();
            var workTypeList = this.mapper.Map<List<EbaStrKvpDto>>((await workTypeRepository.GetAllAsync())).OrderBy(x => x.Value).ToList();
            var advertNumberList = this.mapper.Map<List<EbaStrKvpDto>>(advertList.Select(x => x.AdvertNumberId).Distinct().ToList()).OrderBy(x => x.Key).ToList();

            if (advertList != null)
            {
                return new FilterPropertiesTreeDto()
                {
                    PositionName = positionList,
                    PositionTypeName = positionTypeList,
                    AdvertPublisherName = advertPublisherList,
                    WorkTypeName = workTypeList,
                    EducationLevelName = educationLevelList,
                    AdvertNumberId = advertNumberList,
                };
            }
            else
            {
                return new FilterPropertiesTreeDto();
            }

        }

        /*public async Task<FilterPropertiesTreeDto> Handle(GetAllAvailableFilterPropertiesQueryRequest request, CancellationToken cancellationToken)
        {
            var advertList = advertRepository.GetAllAsync().Result.ToList();

            if (advertList != null)
            {
                return new FilterPropertiesTreeDto()
                {
                    PositionName = advertList.Select(x => x.PositionName).Distinct().ToList(),
                    PositionTypeName = advertList.Select(x => x.PositionTypeName).Distinct().ToList(),
                    AdvertPublisherName = advertList.Select(x => x.AdvertPublisherName).Distinct().ToList(),
                    WorkTypeName = advertList.Select(x => x.WorkTypeName).Distinct().ToList(),
                    EducationLevelName = advertList.Select(x => x.EducationLevelName).Distinct().ToList(),
                    AdvertNumberId = advertList.Select(x => x.AdvertNumberId).Distinct().ToList(),
                };
            }
            else
            {
                return new FilterPropertiesTreeDto();
            }
        }*/
    }
}
