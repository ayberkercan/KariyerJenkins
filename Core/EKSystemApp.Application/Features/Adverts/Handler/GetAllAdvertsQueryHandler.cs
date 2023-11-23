using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class GetAllAdvertsQueryHandler : IRequestHandler<GetAllAdvertsQueryRequest, ICollection<AdvertListDto>>
    {
        private readonly IGenericRepository<AdvertCreate> advertRepository;
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;

        public GetAllAdvertsQueryHandler(IGenericRepository<AdvertCreate> advertRepository, IEbaRepository ebaRepository, IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        /*public async Task<ICollection<AdvertListDto>> Handle(GetAllAdvertsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await this.advertRepository.GetAllAsync()).ToList(); //portalda kayıtlı ilanlar

            var ebaData = await ebaRepository.GetEbaEmployeeRequestForms(); //eBA'da oluşturulan formlar

            var intersectedDataList = new List<AdvertCreate>(); //birleşik kayıtları atacağımız yeni liste tanımlanır

            foreach (var advert in data) //eBA ile eşleşen processId bilgisine ait portaldaki kayıtları dönerek kontrol ediyoruz.
            {
                foreach (var ebaForm in ebaData)
                {
                    if (ebaForm.EbaProcessId == advert.EbaProcessId)
                    {
                        intersectedDataList.Add(advert);
                    }
                }
            }

            return this.mapper.Map<ICollection<AdvertListDto>>(intersectedDataList);
        }*/


        public async Task<ICollection<AdvertListDto>> Handle(GetAllAdvertsQueryRequest request, CancellationToken cancellationToken)
        {
            var portalAdverts = (await advertRepository.GetAllAsync()).ToList(); //portalda kayıtlı ilanlar

            var ebaForms = await ebaRepository.GetEbaEmployeeRequestForms(); //eBA'da oluşturulan formlar

            var intersectedAdverts = portalAdverts  //processId bilgisi eşleşen veriler bir liste değişkenine eklenir.
                .Where(advert => ebaForms.Any(ebaForm => ebaForm.EbaProcessId == advert.EbaProcessId))
                .ToList();

            return mapper.Map<ICollection<AdvertListDto>>(intersectedAdverts);
        }

    }
}
