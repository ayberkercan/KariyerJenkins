using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaGroupQueryHandler : IRequestHandler<GetEbaGroupQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;

        public GetEbaGroupQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaGroupQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await this.ebaRepository.GetEbaItemsByUpObjId<EbaKvpDto>(request.Request.UpKey);
            return this.mapper.Map<ICollection<EbaKvpDto>>(userData);
        }
    }
}
