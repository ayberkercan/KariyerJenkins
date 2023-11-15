using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Features.Members.CountriesTree.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Members.CountriesTree.Handlers.List
{
    public class GetEbaCountryTreeQueryHandler : IRequestHandler<GetEbaCountryTreeQueryRequest, ICollection<CountryTreeDto>>
    {
        private readonly IEbaRepository _ebaRepository;

        public GetEbaCountryTreeQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            _ebaRepository = ebaRepository;
        }

        public async Task<ICollection<CountryTreeDto>> Handle(GetEbaCountryTreeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _ebaRepository.GetCountryTreeById((request.Key).ToUpper());

            return data;
        }
    }
}
