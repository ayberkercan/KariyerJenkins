using AutoMapper;
using EKSystemApp.Application.DTO.AdStatus;
using EKSystemApp.Application.DTO.JobCategory;
using EKSystemApp.Application.Features.JobCategories.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.JobCategories.Handler.List
{
    public class GetJobCategoriesQueryHandler : IRequestHandler<GetJobCategoriesQueryRequest, ICollection<JobCategoryDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<AdStatus> genericRepository;

        public GetJobCategoriesQueryHandler(IMapper mapper, IGenericRepository<AdStatus> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<JobCategoryDto>> Handle(GetJobCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<JobCategoryDto>>(data);
        }
    }
}
