using EKSystemApp.Application.Features.Authentication.Commands.Update;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.Update
{
    public class UpdateUserQueryHandler : IRequestHandler<UpdateUserCommandRequest>
    {
        private readonly IGenericRepository<AppUser> repository;
        public UpdateUserQueryHandler(IGenericRepository<AppUser> repository)
        {
            this.repository = repository;
        }
        public async Task<Unit> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var getUser = await this.repository.GetByIdAsync(request.Id);
            if (getUser != null)
            {
                getUser.FirstName = request.FirstName;
                getUser.LastName = request.LastName;
                getUser.Email = request.Email;
                getUser.Registry = request.Registry;
                getUser.AppRoleId = request.RoleId;
                getUser.AppUserCompanies = request.AppUserCompanies;
                getUser.AppUserMenus = request.AppUserMenus;
            }
            return Unit.Value;
        }
    }
}
