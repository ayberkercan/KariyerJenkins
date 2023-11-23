﻿using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;
using Nest;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class GetAllFilteredAdvertsQueryHandler : IRequestHandler<GetAllFilteredAdvertsQueryRequest, ICollection<AdvertListDto>>
    {
        private readonly IGenericRepository<AdvertCreate> advertRepository;
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;

        public GetAllFilteredAdvertsQueryHandler(IGenericRepository<AdvertCreate> advertRepository, IEbaRepository ebaRepository, IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<AdvertListDto>> Handle(GetAllFilteredAdvertsQueryRequest request, CancellationToken cancellationToken)
        {
            var portalAdverts = (await this.advertRepository.GetAllAsync()).ToList(); //portalda kayıtlı ilanlar

            var ebaForms = await ebaRepository.GetEbaEmployeeRequestForms(request); //eBA'da oluşturulan formlar
            
            var filterDto = request.Request.Request; //filtre içeriği tanımlanır.

            var intersectedAdverts = portalAdverts //processId bilgisi eşleşen veriler bir liste değişkenine eklenir.
                .Where(advert => ebaForms.Any(ebaForm => ebaForm.EbaProcessId == advert.EbaProcessId))
                .ToList();

            if (filterDto != null) //eBA'dan uygun kayıtlar döndükten sonra eBA'da olmayan, portaldaki bilgiler için ikinci kez filtrelenir
            {
                intersectedAdverts = FilterByDateRange(intersectedAdverts, filterDto.StartDate, filterDto.EndDate);
                intersectedAdverts = FilterByString(intersectedAdverts, filterDto.PositionTypeName, x => x.PositionTypeName);
                intersectedAdverts = FilterByString(intersectedAdverts, filterDto.AdvertPublisherName, x => x.AdvertPublisherName);
                intersectedAdverts = FilterByString(intersectedAdverts, filterDto.AdvertNumberId.ToString(), x => x.AdvertNumberId.ToString());
            }

            return this.mapper.Map<ICollection<AdvertListDto>>(intersectedAdverts); //tipi dönüştürülüp sonuç döner.
        }

        private static List<AdvertCreate> FilterByDateRange(List<AdvertCreate> data, DateTime? startDate, DateTime? endDate)
        {
            var filteredData = data;

            if (startDate != null && startDate != DateTime.MinValue && endDate != null && endDate != DateTime.MinValue)
            {
                startDate = startDate.Value.Date;
                endDate = endDate.Value.Date.AddDays(1).AddTicks(-1);

                filteredData = data
                    .Where(result => result.StartDate <= endDate && result.EndDate.Date >= startDate)
                    .ToList();
            }

            return filteredData;
        }

        private static List<AdvertCreate> FilterByString(List<AdvertCreate> data, string value, Func<AdvertCreate, string> selector)
        {
            var filteredData = data;

            if (!String.IsNullOrEmpty(value))
            {
                filteredData = data.Where(x => selector(x).ToUpper().Contains(value.ToUpper())).ToList();
            }

            return filteredData;
        }
    }
}
