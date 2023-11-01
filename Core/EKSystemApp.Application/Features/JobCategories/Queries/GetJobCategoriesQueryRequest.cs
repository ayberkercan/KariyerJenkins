using EKSystemApp.Application.DTO.JobCategory;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.JobCategories.Queries
{
    public class GetJobCategoriesQueryRequest: IRequest<ICollection<JobCategoryDto>>
    {
    }
}
