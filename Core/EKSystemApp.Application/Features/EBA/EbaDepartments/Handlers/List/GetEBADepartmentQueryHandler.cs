using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaDepartment;
using EKSystemApp.Application.Features.EBA.EbaDepartments.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.EbaDepartments.Handlers.List
{
    public class GetEBADepartmentQueryHandler : IRequestHandler<GetEBADepartmentQueryRequest, ICollection<EbaDepartmentDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<EbaDepartment> genericRepository;

        public GetEBADepartmentQueryHandler(IMapper mapper, IGenericRepository<EbaDepartment> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<EbaDepartmentDto>> Handle(GetEBADepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<EbaDepartmentDto>>(data);
        }
    }
}
