using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Members.Education.Departments.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Education.Departments.Handlers.List
{
    public class GetEbaEducationDepartmentQueryHandler : IRequestHandler<GetEbaEducationDeparmentQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaRepository ebaRepository;

        public GetEbaEducationDepartmentQueryHandler(IEbaRepository ebaRepository)
        {
            this.ebaRepository = ebaRepository;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaEducationDeparmentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = ebaRepository.GetEbaEducationDepartments().Result;

            return data;
        }
    }
}
