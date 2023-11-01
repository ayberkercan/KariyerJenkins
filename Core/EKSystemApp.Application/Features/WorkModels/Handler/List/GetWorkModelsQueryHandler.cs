using AutoMapper;
using EKSystemApp.Application.DTO.WorkModel;
using EKSystemApp.Application.Features.WorkModels.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.WorkModels.Handler.List
{
    public class GetWorkModelsQueryHandler : IRequestHandler<GetWorkModelsQueryRequest, ICollection<WorkModelDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<WorkModel> genericRepository;

        public GetWorkModelsQueryHandler(IMapper mapper, IGenericRepository<WorkModel> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<WorkModelDto>> Handle(GetWorkModelsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<WorkModelDto>>(data);
        }
    }
}
