using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaGeneralSkillsQueryHandler : IRequestHandler<GetEbaGeneralSkillsQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;

        public GetEbaGeneralSkillsQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaGeneralSkillsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.ebaRepository.GetEbaGeneralSkills();
            return this.mapper.Map<ICollection<EbaKvpDto>>(data);
        }
    }
}
