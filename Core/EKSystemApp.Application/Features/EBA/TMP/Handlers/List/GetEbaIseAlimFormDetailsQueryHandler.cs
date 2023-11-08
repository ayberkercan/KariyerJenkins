using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaIseAlimFormDetailsQueryHandler : IRequestHandler<GetEbaIseAlimFormDetailsQueryRequest, EbaIseAlimTurkuvazFormDto>
    {
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;

        public GetEbaIseAlimFormDetailsQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<EbaIseAlimTurkuvazFormDto> Handle(GetEbaIseAlimFormDetailsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = ebaRepository.GetIseAlimTurkuvazFormDetailsByProcessId(request.Request).Result;
            
            return data;
        }
    }
}
