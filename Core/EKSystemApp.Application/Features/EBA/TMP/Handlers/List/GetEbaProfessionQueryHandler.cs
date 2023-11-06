using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaProfessionQueryHandler : IRequestHandler<GetEbaProfessionQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaRepository _ebaRepository;
        private readonly IMapper _mapper;

        public GetEbaProfessionQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            _ebaRepository = ebaRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaProfessionQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await _ebaRepository.GetEbaProfessionsByParameters(request.Request);

            return userData;
        }
    }
}
