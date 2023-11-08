using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaForeignLanguagesQueryHandler : IRequestHandler<GetEbaForeignLanguagesQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaRepository _ebaRepository;
        private readonly IMapper mapper;

        public GetEbaForeignLanguagesQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            _ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaForeignLanguagesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _ebaRepository.GetEbaForeignLanguages();
            return this.mapper.Map<ICollection<EbaStrKvpDto>>(data);
        }
    }
}
