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
    public class GetEbaIseAlimFormDetailsQueryHandler : IRequestHandler<GetEbaIseAlimFormDetailsQueryRequest, EbaIseAlimTurkuvazFormDto>
    {
        private readonly IEbaRepository _ebaRepository;
        private readonly IMapper _mapper;

        public GetEbaIseAlimFormDetailsQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            _ebaRepository = ebaRepository;
            _mapper = mapper;
        }

        public async Task<EbaIseAlimTurkuvazFormDto> Handle(GetEbaIseAlimFormDetailsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = _ebaRepository.GetIseAlimTurkuvazFormDetailsByProcessId(request.Request).Result;
            
            return data;
        }
    }
}
