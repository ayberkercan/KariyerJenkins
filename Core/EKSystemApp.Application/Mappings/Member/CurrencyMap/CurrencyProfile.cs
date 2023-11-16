using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Domain.Entities.Member.Countries;
using EKSystemApp.Domain.Entities.Member.Currency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.Member.CurrencyMap
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<Currencies, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));
        }
    }
}
